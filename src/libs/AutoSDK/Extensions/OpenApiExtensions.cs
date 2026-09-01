using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using AutoSDK.Helpers;
using Microsoft.OpenApi;
using AutoSDK.Models;
using Microsoft.OpenApi.Reader;
using Microsoft.OpenApi.YamlReader;

namespace AutoSDK.Extensions;

public static class OpenApiExtensions
{
    private const string PreservePrimitiveUnionExtension = "x-autosdk-preserve-primitive-union";

    private sealed class SchemaReferenceEqualityComparer : IEqualityComparer<IOpenApiSchema>
    {
        public static SchemaReferenceEqualityComparer Instance { get; } = new();

        public bool Equals(IOpenApiSchema? x, IOpenApiSchema? y)
        {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode(IOpenApiSchema obj)
        {
            return RuntimeHelpers.GetHashCode(obj);
        }
    }

    private enum YamlKey : byte
    {
        None,
        Other,
        Type,
        Enum,
        AnyOf,
        OneOf,
        Nullable,
    }

    private readonly struct YamlLine
    {
        public YamlLine(int start, int end, int rawIndent, int keyStart, bool hasSequenceMarker, YamlKey key)
        {
            Start = start;
            End = end;
            RawIndent = rawIndent;
            KeyStart = keyStart;
            HasSequenceMarker = hasSequenceMarker;
            Key = key;
        }

        public int Start { get; }
        public int End { get; }
        public int RawIndent { get; }
        public int KeyStart { get; }
        public int KeyIndent => KeyStart - Start;
        public bool HasSequenceMarker { get; }
        public YamlKey Key { get; }
    }

    private readonly struct TextReplacement
    {
        public TextReplacement(int start, int length, string value)
        {
            Start = start;
            Length = length;
            Value = value;
        }

        public int Start { get; }
        public int Length { get; }
        public string Value { get; }
    }

    private readonly struct JsonPathSegment
    {
        public JsonPathSegment(string propertyName)
        {
            PropertyName = propertyName;
            Index = 0;
            IsArrayIndex = false;
        }

        public JsonPathSegment(int index)
        {
            PropertyName = null;
            Index = index;
            IsArrayIndex = true;
        }

        public string? PropertyName { get; }
        public int Index { get; }
        public bool IsArrayIndex { get; }
    }

    private sealed class OpenApiCompatibilityVisitor : OpenApiVisitorBase
    {
        private static readonly JsonSchemaType[] NonNullSchemaTypes =
        [
            JsonSchemaType.String,
            JsonSchemaType.Number,
            JsonSchemaType.Integer,
            JsonSchemaType.Boolean,
            JsonSchemaType.Array,
            JsonSchemaType.Object,
        ];

        private readonly bool restoreCollapsedPrimitiveUnions;
        private readonly bool normalizeNullEnumValues;

        public OpenApiCompatibilityVisitor(
            bool restoreCollapsedPrimitiveUnions,
            bool normalizeNullEnumValues)
        {
            this.restoreCollapsedPrimitiveUnions = restoreCollapsedPrimitiveUnions;
            this.normalizeNullEnumValues = normalizeNullEnumValues;
        }

        public override void Visit(IOpenApiSchema schema)
        {
            if (schema is OpenApiSchemaReference)
            {
                return;
            }

            if (schema is not OpenApiSchema concreteSchema)
            {
                return;
            }

            concreteSchema.Extensions?.Remove(PreservePrimitiveUnionExtension);
            if (normalizeNullEnumValues && concreteSchema.Enum is { } enumValuesToNormalize)
            {
                for (var index = 0; index < enumValuesToNormalize.Count; index++)
                {
                    if (enumValuesToNormalize[index].IsJsonNullSentinel())
                    {
                        enumValuesToNormalize[index] = null!;
                    }
                }
            }

            if (concreteSchema.Type == JsonSchemaType.Null &&
                concreteSchema.Enum is { Count: 1 } enumValues &&
                (enumValues[0] is null || enumValues[0].IsJsonNullSentinel()))
            {
                // Preserve AutoSDK's established identity for the OpenAPI 3.0
                // legacy `enum: [null]` form while 3.10 requires an explicit
                // null type to retain the enum during parsing.
                concreteSchema.Type = null;
            }

            if (!restoreCollapsedPrimitiveUnions)
            {
                return;
            }

            if (
                schema.AnyOf is { Count: > 0 } ||
                schema.OneOf is { Count: > 0 } ||
                schema.Type is not { } combinedType)
            {
                return;
            }

            var variants = new List<IOpenApiSchema>(NonNullSchemaTypes.Length);
            foreach (var schemaType in NonNullSchemaTypes)
            {
                if ((combinedType & schemaType) == schemaType)
                {
                    variants.Add(new OpenApiSchema { Type = schemaType });
                }
            }

            if (variants.Count <= 1)
            {
                return;
            }

            concreteSchema.AnyOf = variants;
            concreteSchema.Type = (combinedType & JsonSchemaType.Null) == JsonSchemaType.Null
                ? JsonSchemaType.Null
                : null;
        }
    }

    public static JsonNode? GetLegacyExample(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));
#pragma warning disable CS0618 // Preserve established OpenAPI 3.0 `example` behavior on Microsoft.OpenApi 3.10.
        return schema is OpenApiSchemaReference schemaReference
            ? schemaReference.Target?.Example
            : schema.Example;
#pragma warning restore CS0618
    }

    private readonly struct SecurityParameterMatcher : IEquatable<SecurityParameterMatcher>
    {
        public SecurityParameterMatcher(
            ParameterLocation location,
            string name)
        {
            Location = location;
            Name = name;
        }

        public ParameterLocation Location { get; }
        public string Name { get; }

        public bool Equals(SecurityParameterMatcher other)
        {
            return Location == other.Location &&
                   string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object? obj)
        {
            return obj is SecurityParameterMatcher other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int)Location * 397) ^ StringComparer.OrdinalIgnoreCase.GetHashCode(Name ?? string.Empty);
            }
        }
    }

    public static OpenApiDocument GetOpenApiDocument(
        this string yamlOrJson,
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return yamlOrJson.GetOpenApiDocument(settings.ToCoreSettings(), cancellationToken);
    }

    public static OpenApiDocument GetOpenApiDocument(
        this string yamlOrJson,
        CoreSettings settings,
        CancellationToken cancellationToken = default)
    {
        return GetOpenApiDocumentWithMetrics(
            yamlOrJson,
            settings,
            out _,
            cancellationToken);
    }

    internal static OpenApiDocument GetOpenApiDocumentWithMetrics(
        this string yamlOrJson,
        CoreSettings settings,
        out OpenApiParsingTimes parsingTimes,
        CancellationToken cancellationToken = default)
    {
        yamlOrJson = yamlOrJson ?? throw new ArgumentNullException(nameof(yamlOrJson));

        if (SpecFormatDetector.DetectFormat(yamlOrJson) == SpecFormat.GrpcProto)
        {
            throw new NotSupportedException(SpecFormatDetector.GrpcProtoPipelineNotSupportedMessage);
        }

        var readerSettings = new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        };
        readerSettings.AddYamlReader();

        var normalizeJsonNullEnumValues = LooksLikeJson(yamlOrJson);
        var readResult = ParseOpenApiDocument(yamlOrJson, readerSettings, out parsingTimes);
        var openApiDocument = readResult.Document;
        var diagnostics = readResult.Diagnostic;
        if (openApiDocument == null &&
            TryPromoteOpenApiFragment(yamlOrJson, out var promotedText))
        {
            Console.WriteLine("Detected OpenAPI fragment without header. Retrying with synthesized metadata.");
            readResult = ParseOpenApiDocument(promotedText, readerSettings, out var retryParsingTimes);
            parsingTimes += retryParsingTimes;
            openApiDocument = readResult.Document;
            diagnostics = readResult.Diagnostic;
            normalizeJsonNullEnumValues = LooksLikeJson(promotedText);
        }
        if (openApiDocument == null)
        {
            var diagnosticMessages = diagnostics?.Errors.Select(static error => error.Message).ToArray() ?? [];
            throw new InvalidOperationException(
                diagnosticMessages.Length == 0
                    ? "Document is null"
                    : "Document is null: " + string.Join("; ", diagnosticMessages));
        }
        if (!settings.IgnoreOpenApiErrors && diagnostics?.Errors.Any() == true)
        {
            throw new AggregateException(diagnostics.Errors.Select(x => new InvalidOperationException(x.Message)));
        }
        if (!settings.IgnoreOpenApiWarnings && diagnostics?.Warnings.Any() == true)
        {
            throw new AggregateException(diagnostics.Warnings.Select(x => new InvalidOperationException(x.Message)));
        }

        var compatibilityWalkerTime = Stopwatch.StartNew();
#if NET
        var allocBeforeCompatibilityWalker = GC.GetTotalAllocatedBytes(precise: true);
#endif
        var restoreCollapsedPrimitiveUnions =
            diagnostics?.SpecificationVersion == OpenApiSpecVersion.OpenApi3_0;
        if (restoreCollapsedPrimitiveUnions || normalizeJsonNullEnumValues)
        {
            new OpenApiWalker(new OpenApiCompatibilityVisitor(
                restoreCollapsedPrimitiveUnions,
                normalizeNullEnumValues: normalizeJsonNullEnumValues)).Walk(openApiDocument);
        }
        compatibilityWalkerTime.Stop();
#if NET
        var allocCompatibilityWalker = GC.GetTotalAllocatedBytes(precise: true) - allocBeforeCompatibilityWalker;
#else
        const long allocCompatibilityWalker = 0;
#endif

        var postProcessingTime = Stopwatch.StartNew();
#if NET
        var allocBeforePostProcessing = GC.GetTotalAllocatedBytes(precise: true);
#endif
        var postSetupAndInjectionTime = Stopwatch.StartNew();
        var allocBeforePostSetupAndInjection = GetParsingAllocatedBytes();
        openApiDocument.Components ??= new OpenApiComponents();
        openApiDocument.Components.Schemas ??= new Dictionary<string, IOpenApiSchema>();
        openApiDocument.Paths ??= new OpenApiPaths();
        openApiDocument.Tags ??= new HashSet<OpenApiTag>();
        openApiDocument.Security ??= new List<OpenApiSecurityRequirement>();
        openApiDocument.Servers ??= new List<OpenApiServer>();

        if (!string.IsNullOrEmpty(settings.BaseUrl))
        {
            openApiDocument.InjectBaseUrl(settings);
        }
        if (settings.SecuritySchemes.Length > 0)
        {
            openApiDocument.InjectSecuritySchemes(settings);
        }
        postSetupAndInjectionTime.Stop();
        var allocPostSetupAndInjection = GetParsingAllocatedBytes() - allocBeforePostSetupAndInjection;

        var postDiscriminatorsTime = Stopwatch.StartNew();
        var allocBeforePostDiscriminators = GetParsingAllocatedBytes();
        if (settings.ComputeDiscriminators)
        {
            openApiDocument = openApiDocument.ComputeDiscriminators();
        }
        postDiscriminatorsTime.Stop();
        var allocPostDiscriminators = GetParsingAllocatedBytes() - allocBeforePostDiscriminators;

        var postMissingPathParametersTime = Stopwatch.StartNew();
        var allocBeforePostMissingPathParameters = GetParsingAllocatedBytes();
        if (settings.AddMissingPathParameters)
        {
            openApiDocument = openApiDocument.AddMissingPathParameters();
        }
        postMissingPathParametersTime.Stop();
        var allocPostMissingPathParameters = GetParsingAllocatedBytes() - allocBeforePostMissingPathParameters;

        var postOverridesAndNamingTime = Stopwatch.StartNew();
        var allocBeforePostOverridesAndNaming = GetParsingAllocatedBytes();
        if (settings.OpenApiOverrides.Length > 0)
        {
            openApiDocument.ApplyOpenApiOverrides(settings);
        }
        if (settings.UseExtensionNaming)
        {
            openApiDocument.ApplyFernRequestNames();
        }
        postOverridesAndNamingTime.Stop();
        var allocPostOverridesAndNaming = GetParsingAllocatedBytes() - allocBeforePostOverridesAndNaming;

        var postSchemaSanitizersTime = Stopwatch.StartNew();
        var allocBeforePostSchemaSanitizers = GetParsingAllocatedBytes();
        var postFernTypeNormalizationTime = Stopwatch.StartNew();
        var allocBeforePostFernTypeNormalization = GetParsingAllocatedBytes();
        openApiDocument.NormalizeFernTypes();
        postFernTypeNormalizationTime.Stop();
        var allocPostFernTypeNormalization = GetParsingAllocatedBytes() - allocBeforePostFernTypeNormalization;

        var postNumericConstraintSanitizationTime = Stopwatch.StartNew();
        var allocBeforePostNumericConstraintSanitization = GetParsingAllocatedBytes();
        openApiDocument.SanitizeNumericConstraints();
        postNumericConstraintSanitizationTime.Stop();
        var allocPostNumericConstraintSanitization = GetParsingAllocatedBytes() - allocBeforePostNumericConstraintSanitization;

        var postLargeIntegerFormatInferenceTime = Stopwatch.StartNew();
        var allocBeforePostLargeIntegerFormatInference = GetParsingAllocatedBytes();
        openApiDocument.InferLargeIntegerFormats();
        postLargeIntegerFormatInferenceTime.Stop();
        var allocPostLargeIntegerFormatInference = GetParsingAllocatedBytes() - allocBeforePostLargeIntegerFormatInference;

        var postDiscriminatorSanitizationTime = Stopwatch.StartNew();
        var allocBeforePostDiscriminatorSanitization = GetParsingAllocatedBytes();
        openApiDocument.SanitizeDiscriminators();
        postDiscriminatorSanitizationTime.Stop();
        var allocPostDiscriminatorSanitization = GetParsingAllocatedBytes() - allocBeforePostDiscriminatorSanitization;
        postSchemaSanitizersTime.Stop();
        var allocPostSchemaSanitizers = GetParsingAllocatedBytes() - allocBeforePostSchemaSanitizers;

        postProcessingTime.Stop();
#if NET
        var allocPostProcessing = GC.GetTotalAllocatedBytes(precise: true) - allocBeforePostProcessing;
#else
        const long allocPostProcessing = 0;
#endif
        parsingTimes += new OpenApiParsingTimes(
            JsonSyntax: TimeSpan.Zero,
            CompatibilityNormalization: TimeSpan.Zero,
            MicrosoftReader: TimeSpan.Zero,
            CompatibilityWalker: compatibilityWalkerTime.Elapsed,
            PostProcessing: postProcessingTime.Elapsed,
            AllocCompatibilityWalker: allocCompatibilityWalker,
            AllocPostProcessing: allocPostProcessing)
        {
            PostSetupAndInjection = postSetupAndInjectionTime.Elapsed,
            PostDiscriminators = postDiscriminatorsTime.Elapsed,
            PostMissingPathParameters = postMissingPathParametersTime.Elapsed,
            PostOverridesAndNaming = postOverridesAndNamingTime.Elapsed,
            PostSchemaSanitizers = postSchemaSanitizersTime.Elapsed,
            PostFernTypeNormalization = postFernTypeNormalizationTime.Elapsed,
            PostNumericConstraintSanitization = postNumericConstraintSanitizationTime.Elapsed,
            PostLargeIntegerFormatInference = postLargeIntegerFormatInferenceTime.Elapsed,
            PostDiscriminatorSanitization = postDiscriminatorSanitizationTime.Elapsed,
            AllocPostSetupAndInjection = allocPostSetupAndInjection,
            AllocPostDiscriminators = allocPostDiscriminators,
            AllocPostMissingPathParameters = allocPostMissingPathParameters,
            AllocPostOverridesAndNaming = allocPostOverridesAndNaming,
            AllocPostSchemaSanitizers = allocPostSchemaSanitizers,
            AllocPostFernTypeNormalization = allocPostFernTypeNormalization,
            AllocPostNumericConstraintSanitization = allocPostNumericConstraintSanitization,
            AllocPostLargeIntegerFormatInference = allocPostLargeIntegerFormatInference,
            AllocPostDiscriminatorSanitization = allocPostDiscriminatorSanitization,
        };

        return openApiDocument;
    }

    private static long GetParsingAllocatedBytes()
    {
#if NET
        return GC.GetTotalAllocatedBytes(precise: true);
#else
        return 0;
#endif
    }

    private static ReadResult ParseOpenApiDocument(
        string text,
        OpenApiReaderSettings readerSettings,
        out OpenApiParsingTimes parsingTimes)
    {
        var jsonSyntaxTime = Stopwatch.StartNew();
#if NET
        var allocBeforeJsonSyntax = GC.GetTotalAllocatedBytes(precise: true);
#endif
        if (TryParseJsonNode(text, out var jsonNode))
        {
            jsonSyntaxTime.Stop();
#if NET
            var allocJsonSyntax = GC.GetTotalAllocatedBytes(precise: true) - allocBeforeJsonSyntax;
#else
            const long allocJsonSyntax = 0;
#endif
            var compatibilityNormalizationTime = Stopwatch.StartNew();
#if NET
            var allocBeforeCompatibilityNormalization = GC.GetTotalAllocatedBytes(precise: true);
#endif
            if (jsonNode is JsonObject rootObject)
            {
                if (IsOpenApi31Document(rootObject))
                {
                    var unsupportedKeywords = new List<string>();
                    NormalizeOpenApi31Keywords(
                        rootObject,
                        isSchemaPosition: false,
                        path: [],
                        unsupportedKeywords);
                    ThrowOnUnsupportedOpenApi31Keywords(unsupportedKeywords);
                }
                else if (TryGetOpenApi3CompatibilityMode(rootObject, out var isOpenApi30))
                {
                    NormalizeOpenApi3CompatibilityKeywords(
                        rootObject,
                        isSchemaPosition: false,
                        isOpenApi30);
                }
            }

            compatibilityNormalizationTime.Stop();
#if NET
            var allocCompatibilityNormalization = GC.GetTotalAllocatedBytes(precise: true) - allocBeforeCompatibilityNormalization;
#else
            const long allocCompatibilityNormalization = 0;
#endif
            var microsoftReaderTime = Stopwatch.StartNew();
#if NET
            var allocBeforeMicrosoftReader = GC.GetTotalAllocatedBytes(precise: true);
#endif
            var result = new OpenApiJsonReader().Read(
                jsonNode!,
                readerSettings.BaseUrl ?? new Uri("https://openapi.net/"),
                readerSettings);
            microsoftReaderTime.Stop();
#if NET
            var allocMicrosoftReader = GC.GetTotalAllocatedBytes(precise: true) - allocBeforeMicrosoftReader;
#else
            const long allocMicrosoftReader = 0;
#endif
            parsingTimes = new OpenApiParsingTimes(
                JsonSyntax: jsonSyntaxTime.Elapsed,
                CompatibilityNormalization: compatibilityNormalizationTime.Elapsed,
                MicrosoftReader: microsoftReaderTime.Elapsed,
                CompatibilityWalker: TimeSpan.Zero,
                PostProcessing: TimeSpan.Zero,
                AllocJsonSyntax: allocJsonSyntax,
                AllocCompatibilityNormalization: allocCompatibilityNormalization,
                AllocMicrosoftReader: allocMicrosoftReader);
            return result;
        }

        jsonSyntaxTime.Stop();
#if NET
        var yamlAllocJsonSyntax = GC.GetTotalAllocatedBytes(precise: true) - allocBeforeJsonSyntax;
#else
        const long yamlAllocJsonSyntax = 0;
#endif
        var yamlCompatibilityNormalizationTime = Stopwatch.StartNew();
#if NET
        var allocBeforeYamlCompatibilityNormalization = GC.GetTotalAllocatedBytes(precise: true);
#endif
        var normalizedText = NormalizeOpenApi3YamlCompatibilityKeywords(text);
        yamlCompatibilityNormalizationTime.Stop();
#if NET
        var yamlAllocCompatibilityNormalization = GC.GetTotalAllocatedBytes(precise: true) - allocBeforeYamlCompatibilityNormalization;
#else
        const long yamlAllocCompatibilityNormalization = 0;
#endif
        var yamlMicrosoftReaderTime = Stopwatch.StartNew();
#if NET
        var allocBeforeYamlMicrosoftReader = GC.GetTotalAllocatedBytes(precise: true);
#endif
        var yamlResult = OpenApiDocument.Parse(
            normalizedText,
            format: "yaml",
            settings: readerSettings);
        yamlMicrosoftReaderTime.Stop();
#if NET
        var yamlAllocMicrosoftReader = GC.GetTotalAllocatedBytes(precise: true) - allocBeforeYamlMicrosoftReader;
#else
        const long yamlAllocMicrosoftReader = 0;
#endif
        parsingTimes = new OpenApiParsingTimes(
            JsonSyntax: jsonSyntaxTime.Elapsed,
            CompatibilityNormalization: yamlCompatibilityNormalizationTime.Elapsed,
            MicrosoftReader: yamlMicrosoftReaderTime.Elapsed,
            CompatibilityWalker: TimeSpan.Zero,
            PostProcessing: TimeSpan.Zero,
            AllocJsonSyntax: yamlAllocJsonSyntax,
            AllocCompatibilityNormalization: yamlAllocCompatibilityNormalization,
            AllocMicrosoftReader: yamlAllocMicrosoftReader);
        return yamlResult;
    }

    private static bool TryParseJsonNode(string text, out JsonNode? jsonNode)
    {
        jsonNode = null;
        if (!LooksLikeJson(text))
        {
            return false;
        }

        try
        {
            jsonNode = JsonNode.Parse(text);
            return jsonNode != null;
        }
        catch (JsonException)
        {
            return false;
        }
    }

    private static bool LooksLikeJson(string text)
    {
        var firstNonWhitespace = 0;
        while (firstNonWhitespace < text.Length && char.IsWhiteSpace(text[firstNonWhitespace]))
        {
            firstNonWhitespace++;
        }

        return firstNonWhitespace < text.Length &&
               text[firstNonWhitespace] is '{' or '[';
    }

    private static bool TryGetOpenApi3CompatibilityMode(
        JsonObject rootObject,
        out bool isOpenApi30)
    {
        var version = rootObject["openapi"]?.ToString();
        isOpenApi30 = version?.StartsWith("3.0", StringComparison.Ordinal) == true;
        return version?.StartsWith("3.", StringComparison.Ordinal) == true;
    }

    private static void NormalizeOpenApi3CompatibilityKeywords(
        JsonNode? node,
        bool isSchemaPosition,
        bool isOpenApi30)
    {
        switch (node)
        {
            case JsonObject jsonObject:
                NormalizeOpenApi3SchemaCompatibilityKeywords(
                    jsonObject,
                    isSchemaPosition,
                    isOpenApi30);

                foreach (var property in jsonObject)
                {
                    if (property.Key.StartsWith("x-", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    if (property.Value is JsonObject schemaMap &&
                        property.Key is "schemas" or "properties" or "patternProperties")
                    {
                        foreach (var schema in schemaMap)
                        {
                            NormalizeOpenApi3CompatibilityKeywords(schema.Value, isSchemaPosition: true, isOpenApi30);
                        }
                        continue;
                    }

                    if (property.Value is JsonArray schemaArray &&
                        property.Key is "allOf" or "anyOf" or "oneOf" or "prefixItems")
                    {
                        for (var index = 0; index < schemaArray.Count; index++)
                        {
                            var schema = schemaArray[index];
                            if (isOpenApi30 &&
                                index == 0 &&
                                property.Key is "anyOf" or "oneOf" &&
                                schema is JsonObject primitiveVariant &&
                                primitiveVariant["type"] != null)
                            {
                                primitiveVariant[PreservePrimitiveUnionExtension] = true;
                            }
                            NormalizeOpenApi3CompatibilityKeywords(schema, isSchemaPosition: true, isOpenApi30);
                        }
                        continue;
                    }

                    var childIsSchema = property.Key is
                        "schema" or "items" or "additionalProperties" or "not" or
                        "contains" or "propertyNames" or "contentSchema";
                    NormalizeOpenApi3CompatibilityKeywords(property.Value, childIsSchema, isOpenApi30);
                }
                break;
            case JsonArray jsonArray:
                foreach (var item in jsonArray)
                {
                    NormalizeOpenApi3CompatibilityKeywords(item, isSchemaPosition: false, isOpenApi30);
                }
                break;
        }
    }

    private static void NormalizeOpenApi3SchemaCompatibilityKeywords(
        JsonObject jsonObject,
        bool isSchemaPosition,
        bool isOpenApi30)
    {
        if (isSchemaPosition &&
            TryGetBooleanValue(jsonObject["nullable"], out var nullable) &&
            nullable)
        {
            if (!jsonObject.TryGetPropertyValue("type", out var declaredType) ||
                declaredType == null)
            {
                jsonObject.Remove("nullable");
                jsonObject["type"] = "null";
            }
            else if (!isOpenApi30 && declaredType is JsonValue)
            {
                jsonObject["type"] = new JsonArray(declaredType.DeepClone(), "null");
                jsonObject.Remove("nullable");
            }
        }

        if (isSchemaPosition &&
            !jsonObject.ContainsKey("type") &&
            jsonObject["enum"] is JsonArray { Count: 1 } enumValues &&
            enumValues[0] is null)
        {
            jsonObject["type"] = "null";
        }
    }

    private static string NormalizeOpenApi3YamlCompatibilityKeywords(string text)
    {
        if ((text.IndexOf("nullable", StringComparison.Ordinal) < 0 &&
             text.IndexOf("anyOf", StringComparison.Ordinal) < 0 &&
             text.IndexOf("oneOf", StringComparison.Ordinal) < 0 &&
             text.IndexOf("enum", StringComparison.Ordinal) < 0))
        {
            return text;
        }

        var versionMatch = Regex.Match(
            text,
            @"(?m)^\s*(?:[""']?openapi[""']?)\s*:\s*[""']?(?<version>3\.[0-9]+)",
            RegexOptions.CultureInvariant);
        if (!versionMatch.Success)
        {
            return text;
        }
        var isOpenApi30 = versionMatch.Groups["version"].Value.StartsWith("3.0", StringComparison.Ordinal);

        var lines = ParseYamlLines(text);
        var replacements = new List<TextReplacement>();
        var normalizedTypeLines = new HashSet<int>();
        var newline = text.Contains("\r\n", StringComparison.Ordinal) ? "\r\n" : "\n";
        for (var i = 0; i < lines.Count; i++)
        {
            var line = lines[i];
            if (line.Key == YamlKey.Nullable &&
                TryGetYamlBooleanTrue(text, line, out var valueEnd))
            {
                if (!TryFindYamlSiblingType(lines, i, out var typeLineIndex))
                {
                    var quotedKey = line.KeyStart < line.End &&
                                    text[line.KeyStart] is '\'' or '"';
                    replacements.Add(new TextReplacement(
                        line.KeyStart,
                        valueEnd - line.KeyStart,
                        quotedKey ? "\"type\": \"null\"" : "type: \"null\""));
                }
                else if (!isOpenApi30 &&
                         normalizedTypeLines.Add(typeLineIndex) &&
                         TryGetYamlScalarValue(text, lines[typeLineIndex], out var typeValueStart, out var typeValueEnd))
                {
                    var typeLine = lines[typeLineIndex];
                    var quotedKey = typeLine.KeyStart < typeLine.End &&
                                    text[typeLine.KeyStart] is '\'' or '"';
                    var originalType = text.Substring(typeValueStart, typeValueEnd - typeValueStart);
                    replacements.Add(new TextReplacement(
                        typeLine.KeyStart,
                        typeValueEnd - typeLine.KeyStart,
                        (quotedKey ? "\"type\": [" : "type: [") + originalType + ", \"null\"]"));
                    replacements.Add(new TextReplacement(line.Start, line.End - line.Start, string.Empty));
                }
            }

            if (IsYamlNullOnlyEnum(text, lines, i) &&
                !TryFindYamlSiblingType(lines, i, out _))
            {
                replacements.Add(new TextReplacement(
                    line.Start,
                    0,
                    new string(' ', line.KeyIndent) + "type: \"null\"" + newline));
            }

            if (isOpenApi30 && IsFirstDirectYamlPrimitiveUnionVariant(lines, i))
            {
                var insertionStart = line.End < text.Length ? line.End + 1 : line.End;
                var marker = new string(' ', line.KeyIndent) +
                             PreservePrimitiveUnionExtension + ": true" + newline;
                if (insertionStart == text.Length &&
                    (text.Length == 0 || text[text.Length - 1] != '\n'))
                {
                    marker = newline + marker;
                }
                replacements.Add(new TextReplacement(insertionStart, 0, marker));
            }
        }

        if (replacements.Count == 0)
        {
            return text;
        }

        replacements.Sort(static (left, right) => left.Start.CompareTo(right.Start));
        var normalizedLength = text.Length;
        foreach (var replacement in replacements)
        {
            normalizedLength += replacement.Value.Length - replacement.Length;
        }

#if NET6_0_OR_GREATER
        return string.Create(
            normalizedLength,
            (Text: text, Replacements: replacements),
            static (destination, state) =>
            {
                var sourcePosition = 0;
                var destinationPosition = 0;
                foreach (var replacement in state.Replacements)
                {
                    var unchangedLength = replacement.Start - sourcePosition;
                    state.Text.AsSpan(sourcePosition, unchangedLength)
                        .CopyTo(destination.Slice(destinationPosition, unchangedLength));
                    destinationPosition += unchangedLength;

                    replacement.Value.AsSpan().CopyTo(destination.Slice(destinationPosition));
                    destinationPosition += replacement.Value.Length;
                    sourcePosition = replacement.Start + replacement.Length;
                }

                state.Text.AsSpan(sourcePosition)
                    .CopyTo(destination.Slice(destinationPosition));
            });
#else
        var builder = new StringBuilder(normalizedLength);
        var position = 0;
        foreach (var replacement in replacements)
        {
            builder.Append(text, position, replacement.Start - position);
            builder.Append(replacement.Value);
            position = replacement.Start + replacement.Length;
        }
        builder.Append(text, position, text.Length - position);
        return builder.ToString();
#endif
    }

    private static bool IsFirstDirectYamlPrimitiveUnionVariant(
        IReadOnlyList<YamlLine> lines,
        int lineIndex)
    {
        var line = lines[lineIndex];
        if (!line.HasSequenceMarker || line.Key != YamlKey.Type)
        {
            return false;
        }

        for (var i = lineIndex - 1; i >= 0; i--)
        {
            var parent = lines[i];
            if (parent.Key == YamlKey.None)
            {
                continue;
            }
            if (parent.KeyIndent >= line.KeyIndent)
            {
                continue;
            }

            if (parent.Key is not (YamlKey.AnyOf or YamlKey.OneOf))
            {
                return false;
            }

            for (var siblingIndex = i + 1; siblingIndex < lineIndex; siblingIndex++)
            {
                var sibling = lines[siblingIndex];
                if (sibling.HasSequenceMarker && sibling.RawIndent == line.RawIndent)
                {
                    return false;
                }
            }

            return true;
        }

        return false;
    }

    private static List<YamlLine> ParseYamlLines(string text)
    {
        var lineCount = 1;
        for (var index = 0; index < text.Length; index++)
        {
            if (text[index] == '\n')
            {
                lineCount++;
            }
        }

        var lines = new List<YamlLine>(lineCount);
        var lineStart = 0;
        while (lineStart < text.Length)
        {
            var lineEnd = text.IndexOf('\n', lineStart);
            if (lineEnd < 0)
            {
                lineEnd = text.Length;
            }

            var position = lineStart;
            while (position < lineEnd && text[position] is ' ' or '\t')
            {
                position++;
            }
            var rawIndent = position - lineStart;
            var hasSequenceMarker = position < lineEnd && text[position] == '-';
            if (hasSequenceMarker)
            {
                position++;
                while (position < lineEnd && text[position] is ' ' or '\t')
                {
                    position++;
                }
            }

            var keyStart = position;
            var key = TryReadYamlKey(text, ref position, lineEnd);
            lines.Add(new YamlLine(
                lineStart,
                lineEnd,
                rawIndent,
                keyStart,
                hasSequenceMarker,
                key));
            lineStart = lineEnd + 1;
        }

        return lines;
    }

    private static YamlKey TryReadYamlKey(string text, ref int position, int lineEnd)
    {
        if (position >= lineEnd || text[position] == '#')
        {
            return YamlKey.None;
        }

        var quote = text[position] is '\'' or '"' ? text[position++] : '\0';
        var keyStart = position;
        if (quote != '\0')
        {
            while (position < lineEnd && text[position] != quote)
            {
                position++;
            }
            if (position >= lineEnd)
            {
                return YamlKey.None;
            }

            var key = GetTrackedYamlKey(text, keyStart, position - keyStart);
            position++;
            while (position < lineEnd && char.IsWhiteSpace(text[position]))
            {
                position++;
            }
            return position < lineEnd && text[position] == ':' ? key : YamlKey.None;
        }

        while (position < lineEnd &&
               text[position] != ':' &&
               !char.IsWhiteSpace(text[position]))
        {
            position++;
        }
        var keyEnd = position;
        while (position < lineEnd && char.IsWhiteSpace(text[position]))
        {
            position++;
        }
        return position < lineEnd && text[position] == ':'
            ? GetTrackedYamlKey(text, keyStart, keyEnd - keyStart)
            : YamlKey.None;
    }

    private static YamlKey GetTrackedYamlKey(string text, int start, int length)
    {
        return length switch
        {
            4 when string.CompareOrdinal(text, start, "type", 0, 4) == 0 => YamlKey.Type,
            4 when string.CompareOrdinal(text, start, "enum", 0, 4) == 0 => YamlKey.Enum,
            5 when string.CompareOrdinal(text, start, "anyOf", 0, 5) == 0 => YamlKey.AnyOf,
            5 when string.CompareOrdinal(text, start, "oneOf", 0, 5) == 0 => YamlKey.OneOf,
            8 when string.CompareOrdinal(text, start, "nullable", 0, 8) == 0 => YamlKey.Nullable,
            _ => YamlKey.Other,
        };
    }

    private static bool TryGetYamlBooleanTrue(
        string text,
        YamlLine line,
        out int valueEnd)
    {
        valueEnd = line.KeyStart;
        var colon = text.IndexOf(':', line.KeyStart, line.End - line.KeyStart);
        if (colon < 0)
        {
            return false;
        }

        var position = colon + 1;
        while (position < line.End && char.IsWhiteSpace(text[position]))
        {
            position++;
        }

        const string value = "true";
        if (position + value.Length > line.End ||
            string.Compare(text, position, value, 0, value.Length, StringComparison.OrdinalIgnoreCase) != 0)
        {
            return false;
        }

        valueEnd = position + value.Length;
        return valueEnd == line.End ||
               char.IsWhiteSpace(text[valueEnd]) ||
               text[valueEnd] == '#';
    }

    private static bool TryFindYamlSiblingType(
        IReadOnlyList<YamlLine> lines,
        int schemaKeywordLineIndex,
        out int typeLineIndex)
    {
        typeLineIndex = -1;
        var schemaKeywordLine = lines[schemaKeywordLineIndex];
        for (var i = schemaKeywordLineIndex - 1; i >= 0; i--)
        {
            var candidate = lines[i];
            if (candidate.Key == YamlKey.None)
            {
                continue;
            }
            if (candidate.KeyIndent < schemaKeywordLine.KeyIndent)
            {
                break;
            }
            if (candidate.HasSequenceMarker && candidate.RawIndent < schemaKeywordLine.KeyIndent)
            {
                if (!schemaKeywordLine.HasSequenceMarker &&
                    candidate.KeyIndent == schemaKeywordLine.KeyIndent &&
                    candidate.Key == YamlKey.Type)
                {
                    typeLineIndex = i;
                    return true;
                }
                break;
            }
            if (candidate.KeyIndent == schemaKeywordLine.KeyIndent &&
                candidate.Key == YamlKey.Type)
            {
                typeLineIndex = i;
                return true;
            }
        }

        for (var i = schemaKeywordLineIndex + 1; i < lines.Count; i++)
        {
            var candidate = lines[i];
            if (candidate.Key == YamlKey.None)
            {
                continue;
            }
            if (candidate.KeyIndent < schemaKeywordLine.KeyIndent ||
                candidate.HasSequenceMarker && candidate.RawIndent < schemaKeywordLine.KeyIndent)
            {
                break;
            }
            if (candidate.KeyIndent == schemaKeywordLine.KeyIndent &&
                candidate.Key == YamlKey.Type)
            {
                typeLineIndex = i;
                return true;
            }
        }

        return false;
    }

    private static bool TryGetYamlScalarValue(
        string text,
        YamlLine line,
        out int valueStart,
        out int valueEnd)
    {
        valueStart = line.KeyStart;
        valueEnd = line.KeyStart;
        var colon = text.IndexOf(':', line.KeyStart, line.End - line.KeyStart);
        if (colon < 0)
        {
            return false;
        }

        valueStart = colon + 1;
        while (valueStart < line.End && char.IsWhiteSpace(text[valueStart]))
        {
            valueStart++;
        }
        if (valueStart >= line.End || text[valueStart] is '[' or '{')
        {
            return false;
        }

        valueEnd = valueStart;
        var quote = text[valueStart] is '\'' or '"' ? text[valueStart] : '\0';
        if (quote != '\0')
        {
            valueEnd++;
            while (valueEnd < line.End && text[valueEnd] != quote)
            {
                valueEnd++;
            }
            if (valueEnd < line.End)
            {
                valueEnd++;
            }
            return valueEnd > valueStart + 1;
        }

        while (valueEnd < line.End &&
               !char.IsWhiteSpace(text[valueEnd]) &&
               text[valueEnd] != '#')
        {
            valueEnd++;
        }
        return valueEnd > valueStart;
    }

    private static bool IsYamlNullOnlyEnum(
        string text,
        IReadOnlyList<YamlLine> lines,
        int enumLineIndex)
    {
        var enumLine = lines[enumLineIndex];
        if (enumLine.Key != YamlKey.Enum)
        {
            return false;
        }

        var itemIndex = enumLineIndex + 1;
        while (itemIndex < lines.Count && lines[itemIndex].Key == YamlKey.None &&
               lines[itemIndex].KeyStart >= lines[itemIndex].End)
        {
            itemIndex++;
        }
        if (itemIndex >= lines.Count)
        {
            return false;
        }

        var item = lines[itemIndex];
        if (!item.HasSequenceMarker ||
            item.RawIndent < enumLine.KeyIndent ||
            !IsYamlNullScalar(text, item))
        {
            return false;
        }

        for (var i = itemIndex + 1; i < lines.Count; i++)
        {
            var candidate = lines[i];
            if (candidate.Key == YamlKey.None && candidate.KeyStart >= candidate.End)
            {
                continue;
            }
            if (candidate.HasSequenceMarker && candidate.RawIndent == item.RawIndent)
            {
                return false;
            }
            if (candidate.KeyIndent <= enumLine.KeyIndent)
            {
                break;
            }
        }

        return true;
    }

    private static bool IsYamlNullScalar(string text, YamlLine line)
    {
        var start = line.KeyStart;
        var end = line.End;
        while (end > start && char.IsWhiteSpace(text[end - 1]))
        {
            end--;
        }
        if (end - start == 4 &&
            string.Compare(text, start, "null", 0, 4, StringComparison.OrdinalIgnoreCase) == 0)
        {
            return true;
        }

        return end - start == 6 &&
               text[start] is '\'' or '"' &&
               text[end - 1] == text[start] &&
               string.Compare(text, start + 1, "null", 0, 4, StringComparison.OrdinalIgnoreCase) == 0;
    }

    private static void ApplyFernRequestNames(this OpenApiDocument openApiDocument)
    {
        var paths = openApiDocument.Paths;
        if (paths == null)
        {
            return;
        }

        var componentRequestNames = new Dictionary<string, HashSet<string>>(StringComparer.Ordinal);

        foreach (var path in paths)
        {
            var operations = path.Value.Operations;
            if (operations == null)
            {
                continue;
            }

            foreach (var operation in operations)
            {
                if (!TryGetExtensionStringValue(
                        operation.Value.Extensions,
                        "x-fern-request-name",
                        out var requestName) ||
                    string.IsNullOrWhiteSpace(requestName))
                {
                    continue;
                }

                var requestContent = operation.Value.RequestBody?.Content;
                if (requestContent == null)
                {
                    continue;
                }

                foreach (var content in requestContent)
                {
                    var schema = content.Value.Schema;
                    if (schema == null ||
                        TryGetExtensionStringValue(schema.Extensions, "x-fern-type-name", out _))
                    {
                        continue;
                    }

                    var referenceId = schema.GetReferenceId();
                    if (!string.IsNullOrWhiteSpace(referenceId))
                    {
                        var referenceIdValue = referenceId!;
                        if (!componentRequestNames.TryGetValue(referenceIdValue, out var names))
                        {
                            names = new HashSet<string>(StringComparer.Ordinal);
                            componentRequestNames[referenceIdValue] = names;
                        }

                        names.Add(requestName);
                        continue;
                    }

                    SetExtensionStringValue(schema, "x-fern-type-name", requestName);
                }
            }
        }

        var componentSchemas = openApiDocument.Components?.Schemas;
        if (componentSchemas == null)
        {
            return;
        }

        foreach (var pair in componentRequestNames)
        {
            if (pair.Value.Count != 1 ||
                !componentSchemas.TryGetValue(pair.Key, out var schema) ||
                schema == null ||
                TryGetExtensionStringValue(schema.Extensions, "x-fern-type-name", out _))
            {
                continue;
            }

            SetExtensionStringValue(schema, "x-fern-type-name", pair.Value.First());
        }
    }

    private static void SetExtensionStringValue(
        IOpenApiSchema schema,
        string name,
        string value)
    {
        if (schema is not OpenApiSchema openApiSchema)
        {
            return;
        }

        openApiSchema.Extensions ??= new Dictionary<string, IOpenApiExtension>(StringComparer.Ordinal);
        openApiSchema.Extensions[name] = new JsonNodeExtension(JsonValue.Create(value)!);
    }

    private static void NormalizeFernTypes(this OpenApiDocument openApiDocument)
    {
        if (openApiDocument.Components?.Schemas is { } componentSchemas)
        {
            foreach (var schema in componentSchemas.Values)
            {
                NormalizeFernTypeSchema(schema);
            }
        }

        if (openApiDocument.Paths == null)
        {
            return;
        }

        foreach (var path in openApiDocument.Paths)
        {
            if (path.Value.Parameters != null)
            {
                foreach (var parameter in path.Value.Parameters)
                {
                    NormalizeFernTypeSchema(parameter.Schema);
                }
            }

            if (path.Value.Operations == null)
            {
                continue;
            }

            foreach (var operation in path.Value.Operations)
            {
                if (operation.Value.Parameters != null)
                {
                    foreach (var parameter in operation.Value.Parameters)
                    {
                        NormalizeFernTypeSchema(parameter.Schema);
                    }
                }

                if (operation.Value.RequestBody?.Content != null)
                {
                    foreach (var mediaType in operation.Value.RequestBody.Content)
                    {
                        NormalizeFernTypeSchema(mediaType.Value.Schema);
                    }
                }

                if (operation.Value.Responses == null)
                {
                    continue;
                }

                foreach (var response in operation.Value.Responses)
                {
                    if (response.Value.Content == null)
                    {
                        continue;
                    }

                    foreach (var mediaType in response.Value.Content)
                    {
                        NormalizeFernTypeSchema(mediaType.Value.Schema);
                    }
                }
            }
        }
    }

    private static void NormalizeFernTypeSchema(IOpenApiSchema? schema)
    {
        if (schema is not OpenApiSchema concreteSchema)
        {
            return;
        }

        ApplyFernTypeNormalization(concreteSchema);

        if (concreteSchema.Properties != null)
        {
            foreach (var property in concreteSchema.Properties.Values)
            {
                NormalizeFernTypeSchema(property);
            }
        }

        foreach (var child in concreteSchema.AnyOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            NormalizeFernTypeSchema(child);
        }

        foreach (var child in concreteSchema.OneOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            NormalizeFernTypeSchema(child);
        }

        foreach (var child in concreteSchema.AllOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            NormalizeFernTypeSchema(child);
        }

        NormalizeFernTypeSchema(concreteSchema.Items);
        NormalizeFernTypeSchema(concreteSchema.AdditionalProperties);
    }

    private static void ApplyFernTypeNormalization(OpenApiSchema schema)
    {
        if (!TryGetExtensionStringValue(schema.Extensions, "x-fern-type", out var fernType) ||
            string.IsNullOrWhiteSpace(fernType))
        {
            return;
        }

        if (TryParseFernLiteralType(fernType, out var literalValue, out var literalType))
        {
            schema.Type ??= literalType;
            schema.Const ??= literalValue;
            return;
        }

        if (string.Equals(fernType, "datetime", StringComparison.OrdinalIgnoreCase))
        {
            schema.Type ??= JsonSchemaType.String;
            schema.Format ??= "date-time";
            return;
        }

        if (string.Equals(fernType, "optional<datetime>", StringComparison.OrdinalIgnoreCase))
        {
            schema.Type = (schema.Type ?? JsonSchemaType.String) | JsonSchemaType.Null;
            schema.Format ??= "date-time";
        }
    }

    private static bool TryParseFernLiteralType(
        string fernType,
        out string? literalValue,
        out JsonSchemaType literalType)
    {
        literalValue = null;
        literalType = default;

        var match = Regex.Match(
            fernType,
            @"^\s*literal<(?<value>.+)>\s*$",
            RegexOptions.CultureInvariant);
        if (!match.Success)
        {
            return false;
        }

        var rawValue = match.Groups["value"].Value.Trim();

        try
        {
            var node = JsonNode.Parse(rawValue);
            if (node is JsonValue jsonValue)
            {
                if (jsonValue.TryGetValue<string>(out var stringValue))
                {
                    literalValue = stringValue;
                    literalType = JsonSchemaType.String;
                    return true;
                }

                if (jsonValue.TryGetValue<bool>(out var boolValue))
                {
                    literalValue = boolValue ? "true" : "false";
                    literalType = JsonSchemaType.Boolean;
                    return true;
                }

                if (jsonValue.TryGetValue<long>(out var longValue))
                {
                    literalValue = longValue.ToString(CultureInfo.InvariantCulture);
                    literalType = JsonSchemaType.Integer;
                    return true;
                }

                if (jsonValue.TryGetValue<double>(out var doubleValue))
                {
                    literalValue = doubleValue.ToString("R", CultureInfo.InvariantCulture);
                    literalType = JsonSchemaType.Number;
                    return true;
                }
            }
        }
        catch (JsonException)
        {
        }

        literalValue = rawValue.Trim('"');
        literalType = JsonSchemaType.String;
        return true;
    }

    private static bool TryPromoteOpenApiFragment(
        string text,
        out string promotedText)
    {
        promotedText = string.Empty;

        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        return TryPromoteJsonOpenApiFragment(text, out promotedText) ||
               TryPromoteYamlOpenApiFragment(text, out promotedText);
    }

    private static bool TryPromoteJsonOpenApiFragment(
        string text,
        out string promotedText)
    {
        promotedText = string.Empty;

        JsonNode? node;
        try
        {
            node = JsonNode.Parse(text);
        }
        catch
        {
            return false;
        }

        if (node is not JsonObject jsonObject ||
            jsonObject.ContainsKey("openapi") ||
            jsonObject.ContainsKey("swagger") ||
            !LooksLikeOpenApiFragment(jsonObject))
        {
            return false;
        }

        var promotedObject = new JsonObject
        {
            ["openapi"] = "3.0.1",
            ["info"] = new JsonObject
            {
                ["title"] = "AutoSDK Generated Fragment",
                ["version"] = "1.0.0",
            },
        };

        foreach (var property in jsonObject)
        {
            promotedObject[property.Key] = property.Value?.DeepClone();
        }

        promotedText = promotedObject.ToJsonString();
        return true;
    }

    private static bool TryPromoteYamlOpenApiFragment(
        string text,
        out string promotedText)
    {
        promotedText = string.Empty;

        if (Regex.IsMatch(text, @"(?m)^\s*(openapi|swagger)\s*:") ||
            !Regex.IsMatch(text, @"(?m)^\s*(paths|components|tags|servers|security)\s*:"))
        {
            return false;
        }

        promotedText = """
openapi: 3.0.1
info:
  title: AutoSDK Generated Fragment
  version: 1.0.0

""" + text;
        return true;
    }

    private static bool IsOpenApi31Document(JsonObject rootObject)
    {
        return rootObject["openapi"]?.ToString()?.StartsWith("3.1", StringComparison.Ordinal) == true;
    }

    private static void ThrowOnUnsupportedOpenApi31Keywords(List<string> unsupportedKeywords)
    {
        if (unsupportedKeywords.Count == 0)
        {
            return;
        }

        throw new AggregateException(unsupportedKeywords.Select(static message => new InvalidOperationException(message)));
    }

    private static bool NormalizeOpenApi31Keywords(
        JsonNode? node,
        bool isSchemaPosition,
        List<JsonPathSegment> path,
        List<string> unsupportedKeywords)
    {
        return node switch
        {
            JsonObject jsonObject => NormalizeOpenApi31Keywords(
                jsonObject,
                isSchemaPosition,
                path,
                unsupportedKeywords),
            JsonArray jsonArray => NormalizeOpenApi31Keywords(
                jsonArray,
                path,
                unsupportedKeywords),
            _ => false,
        };
    }

    private static bool NormalizeOpenApi31Keywords(
        JsonObject jsonObject,
        bool isSchemaPosition,
        List<JsonPathSegment> path,
        List<string> unsupportedKeywords)
    {
        var changed = NormalizeOpenApi31SchemaKeywords(
            jsonObject,
            isSchemaPosition,
            path,
            unsupportedKeywords);
        NormalizeOpenApi3SchemaCompatibilityKeywords(
            jsonObject,
            isSchemaPosition,
            isOpenApi30: false);

        foreach (var property in jsonObject)
        {
            if (ShouldSkipOpenApi31KeywordTraversal(property.Key))
            {
                continue;
            }

            path.Add(new JsonPathSegment(property.Key));
            if (property.Value is JsonObject schemaMap &&
                property.Key is "schemas" or "properties" or "patternProperties")
            {
                foreach (var schema in schemaMap)
                {
                    path.Add(new JsonPathSegment(schema.Key));
                    changed |= NormalizeOpenApi31Keywords(
                        schema.Value,
                        isSchemaPosition: true,
                        path,
                        unsupportedKeywords);
                    path.RemoveAt(path.Count - 1);
                }
            }
            else if (property.Value is JsonArray schemaArray &&
                     property.Key is "allOf" or "anyOf" or "oneOf" or "prefixItems")
            {
                for (var index = 0; index < schemaArray.Count; index++)
                {
                    var schema = schemaArray[index];
                    if (index == 0 &&
                        property.Key is "anyOf" or "oneOf" &&
                        schema is JsonObject primitiveVariant &&
                        primitiveVariant["type"] != null)
                    {
                        primitiveVariant[PreservePrimitiveUnionExtension] = true;
                    }

                    path.Add(new JsonPathSegment(index));
                    changed |= NormalizeOpenApi31Keywords(
                        schema,
                        isSchemaPosition: true,
                        path,
                        unsupportedKeywords);
                    path.RemoveAt(path.Count - 1);
                }
            }
            else
            {
                var childIsSchema = property.Key is
                    "schema" or "items" or "additionalProperties" or "not" or
                    "contains" or "propertyNames" or "contentSchema";
                changed |= NormalizeOpenApi31Keywords(
                    property.Value,
                    childIsSchema,
                    path,
                    unsupportedKeywords);
            }
            path.RemoveAt(path.Count - 1);
        }

        return changed;
    }

    private static bool NormalizeOpenApi31Keywords(
        JsonArray jsonArray,
        List<JsonPathSegment> path,
        List<string> unsupportedKeywords)
    {
        var changed = false;

        for (var i = 0; i < jsonArray.Count; i++)
        {
            path.Add(new JsonPathSegment(i));
            changed |= NormalizeOpenApi31Keywords(
                jsonArray[i],
                isSchemaPosition: false,
                path,
                unsupportedKeywords);
            path.RemoveAt(path.Count - 1);
        }

        return changed;
    }

    private static bool NormalizeOpenApi31SchemaKeywords(
        JsonObject jsonObject,
        bool isSchemaPosition,
        List<JsonPathSegment> path,
        List<string> unsupportedKeywords)
    {
        if (!LooksLikeSchemaObject(jsonObject, isSchemaPosition))
        {
            return false;
        }

        var changed = false;

        changed |= MoveKeywordToExtension(jsonObject, "propertyNames");
        changed |= MoveKeywordToExtension(jsonObject, "dependentRequired");
        changed |= MoveKeywordToExtension(jsonObject, "dependentSchemas");
        changed |= NormalizeContentEncodingKeyword(jsonObject);
        changed |= NormalizeContentMediaTypeKeyword(jsonObject);
        changed |= MoveKeywordToExtension(jsonObject, "contentSchema");
        changed |= NormalizeUnevaluatedPropertiesKeyword(jsonObject, path, unsupportedKeywords);
        changed |= NormalizeUnevaluatedItemsKeyword(jsonObject);
        changed |= NormalizePrefixItemsKeyword(jsonObject);
        changed |= NormalizeBooleanItemsKeyword(jsonObject);
        changed |= NormalizePatternPropertiesKeyword(jsonObject, path, unsupportedKeywords);

        TrackUnsupportedOpenApi31Keyword(
            jsonObject,
            path,
            unsupportedKeywords,
            "contains",
            "AutoSDK cannot translate array contains constraints into the current model pipeline yet.");
        TrackUnsupportedOpenApi31Keyword(
            jsonObject,
            path,
            unsupportedKeywords,
            "minContains",
            "AutoSDK cannot translate array contains constraints into the current model pipeline yet.");
        TrackUnsupportedOpenApi31Keyword(
            jsonObject,
            path,
            unsupportedKeywords,
            "maxContains",
            "AutoSDK cannot translate array contains constraints into the current model pipeline yet.");

        return changed;
    }

    private static bool NormalizeContentEncodingKeyword(JsonObject jsonObject)
    {
        var changed = false;
        if (TryGetStringValue(jsonObject["contentEncoding"], out var contentEncoding) &&
            !HasFormat(jsonObject))
        {
            switch (contentEncoding)
            {
                case "base64":
                case "base64url":
                    jsonObject["type"] ??= "string";
                    jsonObject["format"] = "byte";
                    changed = true;
                    break;
                case "binary":
                    jsonObject["type"] ??= "string";
                    jsonObject["format"] = "binary";
                    changed = true;
                    break;
            }
        }

        return MoveKeywordToExtension(jsonObject, "contentEncoding") || changed;
    }

    private static bool NormalizeContentMediaTypeKeyword(JsonObject jsonObject)
    {
        var changed = false;
        if (TryGetStringValue(jsonObject["contentMediaType"], out var contentMediaType) &&
            contentMediaType != null &&
            IsBinaryContentMediaType(contentMediaType) &&
            !HasFormat(jsonObject))
        {
            jsonObject["type"] ??= "string";
            jsonObject["format"] = "binary";
            changed = true;
        }

        return MoveKeywordToExtension(jsonObject, "contentMediaType") || changed;
    }

    private static bool NormalizeUnevaluatedPropertiesKeyword(
        JsonObject jsonObject,
        List<JsonPathSegment> path,
        List<string> unsupportedKeywords)
    {
        if (!jsonObject.TryGetPropertyValue("unevaluatedProperties", out var unevaluatedPropertiesNode))
        {
            return false;
        }

        if (TryGetBooleanValue(unevaluatedPropertiesNode, out var allowUnevaluatedProperties) &&
            allowUnevaluatedProperties)
        {
            return MoveKeywordToExtension(jsonObject, "unevaluatedProperties");
        }

        if (jsonObject.TryGetPropertyValue("additionalProperties", out var additionalPropertiesNode))
        {
            if (JsonNode.DeepEquals(additionalPropertiesNode, unevaluatedPropertiesNode))
            {
                return MoveKeywordToExtension(jsonObject, "unevaluatedProperties");
            }

            TrackUnsupportedOpenApi31Keyword(
                jsonObject,
                path,
                unsupportedKeywords,
                "unevaluatedProperties",
                "AutoSDK cannot reconcile it with an existing additionalProperties schema automatically.");
            return false;
        }

        if (!CanMapUnevaluatedPropertiesToAdditionalProperties(jsonObject))
        {
            TrackUnsupportedOpenApi31Keyword(
                jsonObject,
                path,
                unsupportedKeywords,
                "unevaluatedProperties",
                "AutoSDK only auto-maps this keyword when the schema does not rely on composition or regex-based property evaluation.");
            return false;
        }

        var changed = false;
        jsonObject["additionalProperties"] = unevaluatedPropertiesNode?.DeepClone();
        changed = true;
        changed |= MoveKeywordToExtension(jsonObject, "unevaluatedProperties");
        return changed;
    }

    private static bool NormalizeUnevaluatedItemsKeyword(JsonObject jsonObject)
    {
        if (!jsonObject.TryGetPropertyValue("unevaluatedItems", out var unevaluatedItemsNode))
        {
            return false;
        }

        var changed = false;
        if (TryGetBooleanValue(unevaluatedItemsNode, out var allowUnevaluatedItems))
        {
            if (!allowUnevaluatedItems)
            {
                if (jsonObject["prefixItems"] is JsonArray prefixItems &&
                    jsonObject["maxItems"] == null)
                {
                    jsonObject["maxItems"] = prefixItems.Count;
                    changed = true;
                }
                else if (jsonObject["items"] == null &&
                         jsonObject["maxItems"] == null)
                {
                    jsonObject["maxItems"] = 0;
                    changed = true;
                }
            }
        }
        else if (jsonObject["items"] == null)
        {
            jsonObject["items"] = unevaluatedItemsNode?.DeepClone();
            changed = true;
        }

        return MoveKeywordToExtension(jsonObject, "unevaluatedItems") || changed;
    }

    private static bool NormalizePrefixItemsKeyword(JsonObject jsonObject)
    {
        if (jsonObject["prefixItems"] is not JsonArray prefixItems)
        {
            return false;
        }

        var itemCandidates = new JsonArray();
        foreach (var prefixItem in prefixItems)
        {
            itemCandidates.Add(prefixItem?.DeepClone());
        }

        var closeTuple = false;
        if (jsonObject.TryGetPropertyValue("items", out var itemsNode))
        {
            if (TryGetBooleanValue(itemsNode, out var allowAdditionalItems))
            {
                closeTuple = !allowAdditionalItems;
            }
            else
            {
                itemCandidates.Add(itemsNode?.DeepClone());
            }
        }

        if (jsonObject.TryGetPropertyValue("additionalItems", out var additionalItemsNode))
        {
            if (TryGetBooleanValue(additionalItemsNode, out var allowAdditionalTupleItems))
            {
                closeTuple |= !allowAdditionalTupleItems;
            }
            else
            {
                itemCandidates.Add(additionalItemsNode?.DeepClone());
            }
        }

        JsonNode? replacementItems = itemCandidates.Count switch
        {
            0 => null,
            1 => itemCandidates[0]?.DeepClone(),
            _ => new JsonObject
            {
                ["anyOf"] = itemCandidates.DeepClone(),
            },
        };

        var changed = false;
        if (replacementItems != null)
        {
            jsonObject["items"] = replacementItems;
            changed = true;
        }

        if (closeTuple &&
            jsonObject["maxItems"] == null)
        {
            jsonObject["maxItems"] = prefixItems.Count;
            changed = true;
        }

        changed |= jsonObject.Remove("prefixItems");
        changed |= jsonObject.Remove("additionalItems");
        return changed;
    }

    private static bool NormalizeBooleanItemsKeyword(JsonObject jsonObject)
    {
        if (jsonObject.ContainsKey("prefixItems") ||
            !TryGetBooleanValue(jsonObject["items"], out var allowItems))
        {
            return false;
        }

        var changed = false;
        if (!allowItems &&
            jsonObject["maxItems"] == null)
        {
            jsonObject["maxItems"] = 0;
            changed = true;
        }

        return jsonObject.Remove("items") || changed;
    }

    private static bool NormalizePatternPropertiesKeyword(
        JsonObject jsonObject,
        List<JsonPathSegment> path,
        List<string> unsupportedKeywords)
    {
        if (jsonObject["patternProperties"] is not JsonObject patternProperties)
        {
            return false;
        }

        if (patternProperties.Count == 1 &&
            patternProperties.FirstOrDefault() is var patternProperty &&
            IsMatchAllPattern(patternProperty.Key) &&
            !jsonObject.ContainsKey("additionalProperties"))
        {
            jsonObject["additionalProperties"] = patternProperty.Value?.DeepClone();
            var changed = true;
            changed |= MoveKeywordToExtension(jsonObject, "patternProperties");
            return changed;
        }

        TrackUnsupportedOpenApi31Keyword(
            jsonObject,
            path,
            unsupportedKeywords,
            "patternProperties",
            "AutoSDK cannot model regex-keyed object maps beyond a catch-all pattern yet.");
        return false;
    }

    private static bool MoveKeywordToExtension(
        JsonObject jsonObject,
        string keyword)
    {
        if (!jsonObject.TryGetPropertyValue(keyword, out var keywordValue))
        {
            return false;
        }

        jsonObject[GetTrackedKeywordExtensionName(keyword)] = keywordValue?.DeepClone();
        return jsonObject.Remove(keyword);
    }

    private static string GetTrackedKeywordExtensionName(string keyword)
    {
        return "x-autosdk-json-schema-" + keyword;
    }

    private static void TrackUnsupportedOpenApi31Keyword(
        JsonObject jsonObject,
        List<JsonPathSegment> path,
        List<string> unsupportedKeywords,
        string keyword,
        string detail)
    {
        if (!jsonObject.ContainsKey(keyword))
        {
            return;
        }

        var message =
            $"OpenAPI 3.1 keyword '{keyword}' is not supported yet at {BuildJsonPointer(path)}. {detail} " +
            "Simplify the schema or use an OpenAPI override before generation.";
        if (!unsupportedKeywords.Contains(message))
        {
            unsupportedKeywords.Add(message);
        }
    }

    private static bool CanMapUnevaluatedPropertiesToAdditionalProperties(JsonObject jsonObject)
    {
        return !jsonObject.ContainsKey("allOf") &&
               !jsonObject.ContainsKey("anyOf") &&
               !jsonObject.ContainsKey("oneOf") &&
               !jsonObject.ContainsKey("not") &&
               !jsonObject.ContainsKey("if") &&
               !jsonObject.ContainsKey("then") &&
               !jsonObject.ContainsKey("else") &&
               !jsonObject.ContainsKey("patternProperties") &&
               !jsonObject.ContainsKey("dependentSchemas");
    }

    private static bool HasFormat(JsonObject jsonObject)
    {
        return TryGetStringValue(jsonObject["format"], out _);
    }

    private static bool IsBinaryContentMediaType(string mediaType)
    {
        return mediaType.StartsWith("application/octet-stream", StringComparison.OrdinalIgnoreCase) ||
               mediaType.StartsWith("image/", StringComparison.OrdinalIgnoreCase) ||
               mediaType.StartsWith("audio/", StringComparison.OrdinalIgnoreCase) ||
               mediaType.StartsWith("video/", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsMatchAllPattern(string pattern)
    {
        return string.Equals(pattern, ".*", StringComparison.Ordinal) ||
               string.Equals(pattern, "^.*$", StringComparison.Ordinal) ||
               string.Equals(pattern, "^[\\s\\S]*$", StringComparison.Ordinal);
    }

    private static bool ShouldSkipOpenApi31KeywordTraversal(string propertyName)
    {
        return propertyName.StartsWith("x-", StringComparison.OrdinalIgnoreCase);
    }

    private static string BuildJsonPointer(List<JsonPathSegment> path)
    {
        var builder = new StringBuilder("#");
        foreach (var segment in path)
        {
            builder.Append('/');
            if (segment.IsArrayIndex)
            {
                builder.Append(segment.Index.ToString(CultureInfo.InvariantCulture));
                continue;
            }

            var propertyName = segment.PropertyName ?? string.Empty;
            for (var index = 0; index < propertyName.Length; index++)
            {
                switch (propertyName[index])
                {
                    case '~':
                        builder.Append("~0");
                        break;
                    case '/':
                        builder.Append("~1");
                        break;
                    default:
                        builder.Append(propertyName[index]);
                        break;
                }
            }
        }

        return builder.ToString();
    }

    private static bool LooksLikeSchemaObject(
        JsonObject jsonObject,
        bool isSchemaPosition)
    {
        return isSchemaPosition ||
               jsonObject.ContainsKey("$ref") ||
               jsonObject.ContainsKey("type") ||
               jsonObject.ContainsKey("properties") ||
               jsonObject.ContainsKey("allOf") ||
               jsonObject.ContainsKey("oneOf") ||
               jsonObject.ContainsKey("anyOf") ||
               jsonObject.ContainsKey("items") ||
               jsonObject.ContainsKey("additionalProperties") ||
               jsonObject.ContainsKey("patternProperties") ||
               jsonObject.ContainsKey("propertyNames") ||
               jsonObject.ContainsKey("prefixItems") ||
               jsonObject.ContainsKey("unevaluatedProperties") ||
               jsonObject.ContainsKey("unevaluatedItems") ||
               jsonObject.ContainsKey("contentEncoding") ||
               jsonObject.ContainsKey("contentMediaType") ||
               jsonObject.ContainsKey("contentSchema") ||
               jsonObject.ContainsKey("dependentRequired") ||
               jsonObject.ContainsKey("dependentSchemas") ||
               jsonObject.ContainsKey("contains") ||
               jsonObject.ContainsKey("minContains") ||
               jsonObject.ContainsKey("maxContains");
    }

    private static bool TryGetBooleanValue(
        JsonNode? node,
        out bool value)
    {
        value = default;
        return node is JsonValue jsonValue &&
               jsonValue.TryGetValue(out value);
    }

    private static bool TryGetStringValue(
        JsonNode? node,
        out string? value)
    {
        value = null;
        return node is JsonValue jsonValue &&
               jsonValue.TryGetValue(out value) &&
               !string.IsNullOrWhiteSpace(value);
    }

    private static bool LooksLikeOpenApiFragment(JsonObject jsonObject)
    {
        return jsonObject.ContainsKey("paths") ||
               jsonObject.ContainsKey("components") ||
               jsonObject.ContainsKey("tags") ||
               jsonObject.ContainsKey("servers") ||
               jsonObject.ContainsKey("security");
    }

    /// <summary>
    /// Walks all schemas in the document and removes minimum/maximum values
    /// that exceed the representable range of their target C# type.
    /// This prevents issues with values like minimum: -9223372036854776000
    /// which exceed long.MinValue and can cause problems in spec processing.
    /// </summary>
    public static void SanitizeNumericConstraints(this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        if (document.Components?.Schemas == null)
        {
            return;
        }

        foreach (var schema in document.Components.Schemas.Values)
        {
            SanitizeSchemaNumericConstraints(schema);
        }
    }

    public static void InferLargeIntegerFormats(this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        if (document.Components?.Schemas == null)
        {
            return;
        }

        foreach (var schema in document.Components.Schemas.Values)
        {
            InferSchemaLargeIntegerFormats(
                schema,
                propertyName: null,
                inheritedTitle: null,
                inheritedDescription: null);
        }
    }

    public static void ApplyOpenApiOverrides(
        this OpenApiDocument document,
        Settings settings)
    {
        document.ApplyOpenApiOverrides(settings.ToCoreSettings());
    }

    public static void ApplyOpenApiOverrides(
        this OpenApiDocument document,
        CoreSettings settings)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        foreach (var rawOverride in settings.OpenApiOverrides)
        {
            if (!TryParseOpenApiOverride(rawOverride, out var path, out var action))
            {
                Console.WriteLine($"Invalid OpenAPI override '{rawOverride}'. Expected 'path=action'.");
                continue;
            }

            if (!TryResolveOverrideTarget(document, path, out var target))
            {
                Console.WriteLine($"OpenAPI override target '{path}' was not found.");
                continue;
            }

            switch (action)
            {
                case OpenApiOverrideAction.Object:
                    target.Replace(CreateOverrideSchema(target.Schema, action));
                    break;
                case OpenApiOverrideAction.Dictionary:
                    target.Replace(CreateOverrideSchema(target.Schema, action));
                    break;
                case OpenApiOverrideAction.Remove:
                    if (target.Remove == null)
                    {
                        Console.WriteLine($"OpenAPI override target '{path}' cannot be removed.");
                        continue;
                    }

                    target.Remove();
                    break;
                default:
                    throw new InvalidOperationException($"Unsupported OpenAPI override action '{action}'.");
            }
        }
    }

    private static bool TryParseOpenApiOverride(
        string rawOverride,
        out string path,
        out OpenApiOverrideAction action)
    {
        path = string.Empty;
        action = default;

        if (string.IsNullOrWhiteSpace(rawOverride))
        {
            return false;
        }

        var index = rawOverride.LastIndexOf('=');
        if (index <= 0 || index == rawOverride.Length - 1)
        {
            return false;
        }

        path = rawOverride.Substring(0, index).Trim();
        var actionText = rawOverride.Substring(index + 1).Trim();

        return !string.IsNullOrWhiteSpace(path) &&
               Enum.TryParse(actionText, ignoreCase: true, out action);
    }

    private static bool TryResolveOverrideTarget(
        OpenApiDocument document,
        string path,
        out OpenApiOverrideTarget target)
    {
        target = null!;

        const string prefix = "#/components/schemas/";
        if (!path.StartsWith(prefix, StringComparison.Ordinal))
        {
            return false;
        }

        var segments = path.Substring(prefix.Length)
            .Split('/')
            .Where(static x => x.Length > 0)
            .Select(DecodePointerSegment)
            .ToArray();
        if (segments.Length == 0)
        {
            return false;
        }

        var componentId = segments[0];
        if (!(document.Components?.Schemas?.TryGetValue(componentId, out var rootSchema) ?? false))
        {
            return false;
        }

        target = new OpenApiOverrideTarget(
            rootSchema,
            schema => document.Components!.Schemas![componentId] = schema,
            () => document.Components!.Schemas!.Remove(componentId));

        var index = 1;
        while (index < segments.Length)
        {
            if (target.Schema is not OpenApiSchema concreteSchema)
            {
                return false;
            }

            var token = segments[index++];
            switch (token)
            {
                case "properties":
                {
                    if (index >= segments.Length)
                    {
                        return false;
                    }

                    var propertyName = segments[index++];
                    if (!(concreteSchema.Properties?.TryGetValue(propertyName, out var propertySchema) ?? false))
                    {
                        return false;
                    }

                    target = new OpenApiOverrideTarget(
                        propertySchema,
                        schema => concreteSchema.Properties![propertyName] = schema,
                        () =>
                        {
                            concreteSchema.Properties!.Remove(propertyName);
                            if (concreteSchema.Required?.Contains(propertyName) == true)
                            {
                                concreteSchema.Required = new HashSet<string>(
                                    concreteSchema.Required.Where(x => x != propertyName),
                                    StringComparer.Ordinal);
                            }
                        });
                    break;
                }
                case "items":
                {
                    if (concreteSchema.Items == null)
                    {
                        return false;
                    }

                    target = new OpenApiOverrideTarget(
                        concreteSchema.Items,
                        schema => concreteSchema.Items = schema,
                        () => concreteSchema.Items = null);
                    break;
                }
                case "additionalProperties":
                {
                    if (concreteSchema.AdditionalProperties == null)
                    {
                        return false;
                    }

                    target = new OpenApiOverrideTarget(
                        concreteSchema.AdditionalProperties,
                        schema => concreteSchema.AdditionalProperties = schema,
                        () => concreteSchema.AdditionalProperties = null);
                    break;
                }
                case "anyOf":
                case "oneOf":
                case "allOf":
                {
                    if (index >= segments.Length ||
                        !int.TryParse(segments[index++], NumberStyles.Integer, CultureInfo.InvariantCulture, out var itemIndex))
                    {
                        return false;
                    }

                    IList<IOpenApiSchema>? collection = token switch
                    {
                        "anyOf" => concreteSchema.AnyOf,
                        "oneOf" => concreteSchema.OneOf,
                        "allOf" => concreteSchema.AllOf,
                        _ => null,
                    };
                    if (collection == null || itemIndex < 0 || itemIndex >= collection.Count)
                    {
                        return false;
                    }

                    target = new OpenApiOverrideTarget(
                        collection[itemIndex],
                        schema => collection[itemIndex] = schema,
                        () => collection.RemoveAt(itemIndex));
                    break;
                }
                default:
                    return false;
            }
        }

        return true;
    }

    private static string DecodePointerSegment(string segment)
    {
        return segment
            .Replace("~1", "/")
            .Replace("~0", "~");
    }

    private static OpenApiSchema CreateOverrideSchema(
        IOpenApiSchema source,
        OpenApiOverrideAction action)
    {
        if (source is OpenApiSchema schema)
        {
            return action switch
            {
                OpenApiOverrideAction.Object => new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Title = schema.Title,
                    Description = schema.Description,
                    Default = schema.Default,
#pragma warning disable CS0618 // Preserve OpenAPI 3.0 `example` during override normalization.
                    Example = schema.GetLegacyExample(),
#pragma warning restore CS0618
                },
                OpenApiOverrideAction.Dictionary => new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Title = schema.Title,
                    Description = schema.Description,
                    Default = schema.Default,
#pragma warning disable CS0618 // Preserve OpenAPI 3.0 `example` during override normalization.
                    Example = schema.GetLegacyExample(),
#pragma warning restore CS0618
                    AdditionalProperties = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                    },
                },
                _ => throw new InvalidOperationException($"Unsupported OpenAPI override action '{action}'."),
            };
        }

        return action switch
        {
            OpenApiOverrideAction.Object => new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
            },
            OpenApiOverrideAction.Dictionary => new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                AdditionalProperties = new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                },
            },
            _ => throw new InvalidOperationException($"Unsupported OpenAPI override action '{action}'."),
        };
    }

    private sealed class OpenApiOverrideTarget
    {
        public OpenApiOverrideTarget(
            IOpenApiSchema schema,
            Action<IOpenApiSchema> replace,
            Action? remove)
        {
            Schema = schema;
            Replace = replace;
            Remove = remove;
        }

        public IOpenApiSchema Schema { get; }
        public Action<IOpenApiSchema> Replace { get; }
        public Action? Remove { get; }
    }

    private enum OpenApiOverrideAction
    {
        Object,
        Dictionary,
        Remove,
    }

    private static void SanitizeSchemaNumericConstraints(IOpenApiSchema? schema)
    {
        if (schema is not OpenApiSchema concreteSchema)
        {
            return;
        }

        if (!string.IsNullOrEmpty(concreteSchema.Minimum) || !string.IsNullOrEmpty(concreteSchema.Maximum) ||
            !string.IsNullOrEmpty(concreteSchema.ExclusiveMinimum) || !string.IsNullOrEmpty(concreteSchema.ExclusiveMaximum))
        {
            var (min, max) = GetTypeRange(concreteSchema);
            if (IsOutOfRange(concreteSchema.Minimum, min, isMin: true))
            {
                concreteSchema.Minimum = null;
            }
            if (IsOutOfRange(concreteSchema.Maximum, max, isMin: false))
            {
                concreteSchema.Maximum = null;
            }
            if (IsOutOfRange(concreteSchema.ExclusiveMinimum, min, isMin: true))
            {
                concreteSchema.ExclusiveMinimum = null;
            }
            if (IsOutOfRange(concreteSchema.ExclusiveMaximum, max, isMin: false))
            {
                concreteSchema.ExclusiveMaximum = null;
            }
        }

        if (concreteSchema.Properties != null)
        {
            foreach (var property in concreteSchema.Properties.Values)
            {
                SanitizeSchemaNumericConstraints(property);
            }
        }
        foreach (var child in concreteSchema.AnyOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaNumericConstraints(child);
        }
        foreach (var child in concreteSchema.OneOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaNumericConstraints(child);
        }
        foreach (var child in concreteSchema.AllOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaNumericConstraints(child);
        }
        SanitizeSchemaNumericConstraints(concreteSchema.Items);
        SanitizeSchemaNumericConstraints(concreteSchema.AdditionalProperties);
    }

    private static void InferSchemaLargeIntegerFormats(
        IOpenApiSchema? schema,
        string? propertyName,
        string? inheritedTitle,
        string? inheritedDescription)
    {
        if (schema is not OpenApiSchema concreteSchema)
        {
            return;
        }

        if (ShouldInferInt64(
                concreteSchema,
                propertyName,
                inheritedTitle,
                inheritedDescription))
        {
            concreteSchema.Format = "int64";
        }

        if (concreteSchema.Properties != null)
        {
            foreach (var property in concreteSchema.Properties)
            {
                InferSchemaLargeIntegerFormats(
                    property.Value,
                    property.Key,
                    concreteSchema.Title,
                    concreteSchema.Description);
            }
        }
        foreach (var child in concreteSchema.AnyOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            InferSchemaLargeIntegerFormats(
                child,
                propertyName,
                concreteSchema.Title ?? inheritedTitle,
                concreteSchema.Description ?? inheritedDescription);
        }
        foreach (var child in concreteSchema.OneOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            InferSchemaLargeIntegerFormats(
                child,
                propertyName,
                concreteSchema.Title ?? inheritedTitle,
                concreteSchema.Description ?? inheritedDescription);
        }
        foreach (var child in concreteSchema.AllOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            InferSchemaLargeIntegerFormats(
                child,
                propertyName,
                concreteSchema.Title ?? inheritedTitle,
                concreteSchema.Description ?? inheritedDescription);
        }
        InferSchemaLargeIntegerFormats(
            concreteSchema.Items,
            propertyName,
            concreteSchema.Title ?? inheritedTitle,
            concreteSchema.Description ?? inheritedDescription);
        InferSchemaLargeIntegerFormats(
            concreteSchema.AdditionalProperties,
            propertyName,
            concreteSchema.Title ?? inheritedTitle,
            concreteSchema.Description ?? inheritedDescription);
    }

    private static bool ShouldInferInt64(
        OpenApiSchema schema,
        string? propertyName,
        string? inheritedTitle,
        string? inheritedDescription)
    {
        var isInteger = (schema.Type & JsonSchemaType.Integer) == JsonSchemaType.Integer;
        if (!isInteger || !string.IsNullOrWhiteSpace(schema.Format))
        {
            return false;
        }

        return ExceedsInt32Range(schema.Minimum) ||
               ExceedsInt32Range(schema.Maximum) ||
               ExceedsInt32Range(schema.ExclusiveMinimum) ||
               ExceedsInt32Range(schema.ExclusiveMaximum) ||
               ExceedsInt32Range(schema.Default) ||
               ExceedsInt32Range(schema.GetLegacyExample()) ||
               HasLargeIntegerHint(
                   propertyName,
                   schema.Title ?? inheritedTitle,
                   schema.Description ?? inheritedDescription);
    }

    private static bool ExceedsInt32Range(string? value)
    {
        if (string.IsNullOrWhiteSpace(value) ||
            !decimal.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed))
        {
            return false;
        }

        return parsed < int.MinValue || parsed > int.MaxValue;
    }

    private static bool ExceedsInt32Range(JsonNode? value)
    {
        if (!TryGetIntegerValue(value, out var parsed))
        {
            return false;
        }

        return parsed < int.MinValue || parsed > int.MaxValue;
    }

    private static bool TryGetIntegerValue(
        JsonNode? value,
        out long parsed)
    {
        parsed = 0;

        if (value is not JsonValue jsonValue)
        {
            return false;
        }

        if (jsonValue.TryGetValue<long>(out parsed))
        {
            return true;
        }

        if (jsonValue.TryGetValue<int>(out var intValue))
        {
            parsed = intValue;
            return true;
        }

        if (jsonValue.TryGetValue<decimal>(out var decimalValue) &&
            decimal.Truncate(decimalValue) == decimalValue &&
            decimalValue >= long.MinValue &&
            decimalValue <= long.MaxValue)
        {
            parsed = (long)decimalValue;
            return true;
        }

        if (jsonValue.TryGetValue<string>(out var stringValue) &&
            long.TryParse(stringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out parsed))
        {
            return true;
        }

        return false;
    }

    private static bool HasLargeIntegerHint(
        string? propertyName,
        string? title,
        string? description)
    {
        return HasLargeIntegerHintInAny(propertyName) ||
               HasLargeIntegerHintInAny(title) ||
               HasLargeIntegerHintInAny(description);
    }

    [SuppressMessage("Usage", "CA2249:Consider using 'string.Contains' instead of 'string.IndexOf'", Justification = "StringComparison overloads must remain compatible with older target frameworks.")]
    private static bool HasLargeIntegerHintInAny(string? text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        if (text!.IndexOf("nanosecond", StringComparison.OrdinalIgnoreCase) >= 0 ||
            text.IndexOf(" byte", StringComparison.OrdinalIgnoreCase) >= 0 ||
            text.IndexOf("bytes", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            return true;
        }

        if ((text.IndexOf("unix", StringComparison.OrdinalIgnoreCase) >= 0 ||
             text.IndexOf("epoch", StringComparison.OrdinalIgnoreCase) >= 0) &&
            (text.IndexOf("millisecond", StringComparison.OrdinalIgnoreCase) >= 0 ||
             text.IndexOf("unix_ms", StringComparison.OrdinalIgnoreCase) >= 0 ||
             text.IndexOf("unix ms", StringComparison.OrdinalIgnoreCase) >= 0))
        {
            return true;
        }

        return false;
    }

    public static void SanitizeDiscriminators(this OpenApiDocument document)
    {
        document = document ?? throw new ArgumentNullException(nameof(document));

        var componentIds = new HashSet<string>(
            document.Components?.Schemas?.Keys ?? Enumerable.Empty<string>(),
            StringComparer.Ordinal);

        if (document.Components?.Schemas == null)
        {
            return;
        }

        foreach (var schema in document.Components.Schemas.Values)
        {
            SanitizeSchemaDiscriminators(schema, componentIds);
        }
    }

    private static void SanitizeSchemaDiscriminators(
        IOpenApiSchema? schema,
        ISet<string> componentIds)
    {
        if (schema is not OpenApiSchema concreteSchema)
        {
            return;
        }

        if (concreteSchema.Discriminator?.Mapping is { Count: > 0 } mapping)
        {
            var discriminator = concreteSchema.Discriminator;
            var invalidMappingCount = 0;
            foreach (var mappingEntry in mapping)
            {
                if (mappingEntry.Value.Reference?.Id is not { } id || !componentIds.Contains(id))
                {
                    invalidMappingCount++;
                }
            }

            if (invalidMappingCount > 0)
            {
                var validMappings = new Dictionary<string, OpenApiSchemaReference>(
                    mapping.Count - invalidMappingCount,
                    StringComparer.Ordinal);
                foreach (var mappingEntry in mapping)
                {
                    if (mappingEntry.Value.Reference?.Id is { } id && componentIds.Contains(id))
                    {
                        validMappings.Add(mappingEntry.Key, mappingEntry.Value);
                    }
                }

                var hasCompositionChildren =
                    (concreteSchema.OneOf?.Count ?? 0) > 0 ||
                    (concreteSchema.AnyOf?.Count ?? 0) > 0 ||
                    (concreteSchema.AllOf?.Count ?? 0) > 0;
                var hasDefaultMapping = discriminator?.DefaultMapping != null;

                if (validMappings.Count == 0 && !hasCompositionChildren && !hasDefaultMapping)
                {
                    concreteSchema.Discriminator = null;
                }
                else
                {
                    concreteSchema.Discriminator = new OpenApiDiscriminator
                    {
                        PropertyName = discriminator?.PropertyName,
                        Mapping = validMappings.Count > 0 ? validMappings : null,
                        DefaultMapping = discriminator?.DefaultMapping,
                        Extensions = discriminator?.Extensions != null
                            ? new Dictionary<string, IOpenApiExtension>(discriminator.Extensions)
                            : null,
                    };
                }
            }
        }

        if (concreteSchema.Properties != null)
        {
            foreach (var property in concreteSchema.Properties.Values)
            {
                SanitizeSchemaDiscriminators(property, componentIds);
            }
        }
        foreach (var child in concreteSchema.AnyOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaDiscriminators(child, componentIds);
        }
        foreach (var child in concreteSchema.OneOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaDiscriminators(child, componentIds);
        }
        foreach (var child in concreteSchema.AllOf ?? Enumerable.Empty<IOpenApiSchema>())
        {
            SanitizeSchemaDiscriminators(child, componentIds);
        }
        SanitizeSchemaDiscriminators(concreteSchema.Items, componentIds);
        SanitizeSchemaDiscriminators(concreteSchema.AdditionalProperties, componentIds);
    }

    private static bool IsOutOfRange(string? value, decimal bound, bool isMin)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var parsed) &&
               (isMin ? parsed < bound : parsed > bound);
    }

    private static (decimal Min, decimal Max) GetTypeRange(OpenApiSchema schema)
    {
        var isInteger = (schema.Type & JsonSchemaType.Integer) == JsonSchemaType.Integer;
        if (!isInteger)
        {
            return (decimal.MinValue, decimal.MaxValue);
        }

        return string.Equals(schema.Format, "int32", StringComparison.OrdinalIgnoreCase)
            ? (int.MinValue, int.MaxValue)
            : (long.MinValue, long.MaxValue);
    }
    
    public static void InjectBaseUrl(
        this OpenApiDocument openApiDocument,
        Settings settings)
    {
        openApiDocument.InjectBaseUrl(settings.ToCoreSettings());
    }

    public static void InjectBaseUrl(
        this OpenApiDocument openApiDocument,
        CoreSettings settings)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        if (!Uri.TryCreate(settings.BaseUrl, UriKind.Absolute, out _))
        {
            Console.WriteLine($"Invalid base URL '{settings.BaseUrl}'. Expected an absolute URL (e.g., 'https://api.example.com'). Skipping base URL injection.");
            return;
        }

        openApiDocument.Servers!.Insert(0, new OpenApiServer
        {
            Url = settings.BaseUrl,
        });
    }

    public static string ExpandServerTemplate(
        this OpenApiServer? server,
        Uri? documentSelf = null)
    {
        var url = server?.Url;
        if (string.IsNullOrWhiteSpace(url))
        {
            return string.Empty;
        }

        var expanded = url!;
        var variables = server?.Variables;
        if (variables != null)
        {
            foreach (var pair in variables)
            {
                var name = pair.Key;
                var variable = pair.Value;
                var value = variable?.Default;
                if (string.IsNullOrWhiteSpace(value) &&
                    variable?.Enum is { Count: > 0 })
                {
                    value = variable.Enum[0];
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                expanded = expanded.Replace("{" + name + "}", value);
            }
        }

        if (Uri.TryCreate(expanded, UriKind.Absolute, out var absoluteUri))
        {
            return absoluteUri.ToString();
        }

        if (documentSelf != null &&
            Uri.TryCreate(expanded, UriKind.Relative, out var relativeUri) &&
            Uri.TryCreate(documentSelf, relativeUri, out var resolvedUri))
        {
            return resolvedUri.ToString();
        }

        return expanded;
    }

    public static void InjectSecuritySchemes(
        this OpenApiDocument openApiDocument,
        Settings settings)
    {
        openApiDocument.InjectSecuritySchemes(settings.ToCoreSettings());
    }

    public static void InjectSecuritySchemes(
        this OpenApiDocument openApiDocument,
        CoreSettings settings)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        openApiDocument.Components!.SecuritySchemes = new Dictionary<string, IOpenApiSecurityScheme>();
        openApiDocument.Security = new List<OpenApiSecurityRequirement>();
        var matchers = new HashSet<SecurityParameterMatcher>();

        foreach (var scheme in settings.SecuritySchemes)
        {
            var parts = scheme.Split(':');
            if (parts.Length != 3)
            {
                Console.WriteLine($"Invalid security scheme format '{scheme}'. Expected 'Type:Location:Name' (e.g., 'ApiKey:Header:x-api-key').");
                continue;
            }

            var typePart = parts[0];
            var locationPart = parts[1];
            var namePart = parts[2];

            if (!Enum.TryParse<SecuritySchemeType>(typePart, ignoreCase: true, out var schemeType))
            {
                Console.WriteLine($"Invalid security scheme type '{typePart}'. Expected: ApiKey, Http, OAuth2, OpenIdConnect.");
                continue;
            }

            if (!Enum.TryParse<ParameterLocation>(locationPart, ignoreCase: true, out var location))
            {
                Console.WriteLine($"Invalid parameter location '{locationPart}'. Expected: Header, Query, Cookie.");
                continue;
            }

            string schemeName;
            var securityScheme = new OpenApiSecurityScheme();

            if (schemeType == SecuritySchemeType.Http)
            {
                schemeName = $"http_{ToInvariantLowercase(namePart)}";
                securityScheme.Type = SecuritySchemeType.Http;
                securityScheme.Scheme = namePart;
                securityScheme.In = location;
            }
            else
            {
                schemeName = $"apikey_{ToInvariantLowercase(namePart)}";
                securityScheme.Type = schemeType;
                securityScheme.In = location;
                securityScheme.Name = namePart;
            }

            openApiDocument.AddComponent(schemeName, securityScheme);

            var schemeRef = new OpenApiSecuritySchemeReference(schemeName, openApiDocument);
            openApiDocument.Security!.Add(new OpenApiSecurityRequirement
            {
                [schemeRef] = new List<string>(),
            });
            if (TryCreateSecurityParameterMatcher(schemeType, location, namePart, out var matcher))
            {
                matchers.Add(matcher);
            }
        }

        var pathItems = openApiDocument.Paths != null
            ? openApiDocument.Paths.Values.ToList()
            : new List<IOpenApiPathItem>();
        foreach (var pathItem in pathItems)
        {
            SuppressMatchingSecurityParameters(pathItem.Parameters, matchers);

            foreach (var operation in pathItem.Operations?.Values ?? Enumerable.Empty<OpenApiOperation>())
            {
                operation.Security = null;
                SuppressMatchingSecurityParameters(operation.Parameters, matchers);
            }
        }
    }

    private static void SuppressMatchingSecurityParameters(
        IList<IOpenApiParameter>? parameters,
        ISet<SecurityParameterMatcher> matchers)
    {
        if (parameters == null || parameters.Count == 0 || matchers.Count == 0)
        {
            return;
        }

        for (var i = parameters.Count - 1; i >= 0; i--)
        {
            var parameter = parameters[i];
            if (string.IsNullOrWhiteSpace(parameter.Name))
            {
                continue;
            }

            if (parameter.In is not ParameterLocation parameterLocation)
            {
                continue;
            }

            var matcher = new SecurityParameterMatcher(parameterLocation, parameter.Name!);
            if (matchers.Contains(matcher) ||
                matchers.Any(x =>
                    x.Location == parameterLocation &&
                    string.Equals(x.Name, parameter.Name, StringComparison.OrdinalIgnoreCase)))
            {
                parameters.RemoveAt(i);
            }
        }
    }

    private static bool TryCreateSecurityParameterMatcher(
        SecuritySchemeType schemeType,
        ParameterLocation location,
        string name,
        out SecurityParameterMatcher matcher)
    {
        matcher = default;

        switch (schemeType)
        {
            case SecuritySchemeType.Http:
            case SecuritySchemeType.OAuth2:
            case SecuritySchemeType.OpenIdConnect:
                matcher = new SecurityParameterMatcher(ParameterLocation.Header, "Authorization");
                return true;
            case SecuritySchemeType.ApiKey when !string.IsNullOrWhiteSpace(name):
                matcher = new SecurityParameterMatcher(location, name);
                return true;
            default:
                return false;
        }
    }

    public static OpenApiDocument Simplify(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        var schemasToRemove = new List<KeyValuePair<string, IOpenApiSchema>>();
        var schemasToAdd = new List<KeyValuePair<string, IOpenApiSchema>>();
        foreach (var schema in (openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            // If schema is OneOf and all children have only one enum value, combine them into one schema.
            if (schema.Value.IsOneOf() &&
                (schema.Value.OneOf ?? []).All(child =>
                    (child.Properties ?? new Dictionary<string, IOpenApiSchema>()).Any(subChild =>
                        subChild.Value.IsEnum() &&
                        (subChild.Value.Enum?.Count ?? 0) == 1)))
            {
                var subChildren = (schema.Value.OneOf ?? [])
                    .Select(child =>
                        (child.Properties ?? new Dictionary<string, IOpenApiSchema>()).First(subChild =>
                            subChild.Value.IsEnum() &&
                            (subChild.Value.Enum?.Count ?? 0) == 1))
                    .ToList();
                var newEnum = new OpenApiSchema
                {
                    Enum = subChildren
                        .Where(x => x.Value.Enum != null)
                        .Select(x => x.Value.Enum!.First())
                        .ToArray(),
                    Type = JsonSchemaType.String,
                }.WithKey(schema.Key.ToPropertyName() + subChildren.First().Key.ToPropertyName());
                schemasToAdd.Add(newEnum);

                foreach (var child in schema.Value.OneOf ?? [])
                {
                    var subChild = (child.Properties ?? new Dictionary<string, IOpenApiSchema>()).First(subChild =>
                        subChild.Value.IsEnum() &&
                        (subChild.Value.Enum?.Count ?? 0) == 1);
                    child.Properties?.Remove(subChild.Key);
                    // In OpenApi 3.0+, create a reference using OpenApiSchemaReference
                    var newSubChild = new KeyValuePair<string, IOpenApiSchema>(
                        subChild.Key,
                        new OpenApiSchemaReference(newEnum.Key, openApiDocument, string.Empty));
                    child.Properties?.Add(newSubChild.Key, newSubChild.Value);

                    // Old Code for Microsoft.OpenApi 1.x
                    //newSubChild.Value.Extensions["x-original-schema"] = new OpenApiString(
                    //    subChild.Value.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0));
                    // Note: SerializeAsYaml extension method was removed in Microsoft.OpenApi 3.0
                    // The x-original-schema extension is optional metadata, skipping for now
                }

                // Remove duplicated schemas from OneOf.
                // Skip schemas with references.
                var oneOfCollection = schema.Value.OneOf ?? [];
                if (oneOfCollection.Any(x => !x.IsSchemaReference()))
                {
                    var duplicatedSchemas = new List<IOpenApiSchema>();
                    foreach (var group in oneOfCollection
                                 .GroupBy(x => (x.Properties ?? new Dictionary<string, IOpenApiSchema>())
                                     .Select(y => (y.Key, y.Value.Type, y.Value.Format, y.Value.GetReferenceId()))
                                     .ToImmutableArray().AsEquatableArray())
                                 .Where(x => x.Count() > 1))
                    {
                        var first = group.First();
                        foreach (var schemaToRemove in group.Skip(1))
                        {
                            if (first.ResolveSchema() is { } firstResolved &&
                                schemaToRemove.ResolveSchema() is { } toRemoveResolved)
                            {
                                firstResolved.Description += $"\n{toRemoveResolved.Description}";
                            }
                            duplicatedSchemas.Add(schemaToRemove);
                        }
                    }

                    foreach (var duplicatedSchema in duplicatedSchemas)
                    {
                        schema.Value.OneOf?.Remove(duplicatedSchema);
                    }
                }

                // Simplify OneOf with only one schema.
                if ((schema.Value.OneOf?.Count ?? 0) == 1)
                {
                    schemasToRemove.Add(schema);
                    schemasToAdd.Add(new KeyValuePair<string, IOpenApiSchema>(
                        schema.Key,
                        schema.Value.OneOf!.First()));
                }
            }
        }
        foreach (var schema in schemasToRemove)
        {
            openApiDocument.Components?.Schemas?.Remove(schema.Key);
        }
        foreach (var schema in schemasToAdd)
        {
            openApiDocument.Components?.Schemas?.Add(schema.Key, schema.Value);
        }

        return openApiDocument;
    }

    public static OpenApiDocument SimplifyAllOf(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));

        foreach (var schema in (openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
        {
            var propertiesToAdd = new List<KeyValuePair<string, IOpenApiSchema>>();
            var propertiesToRemove = new List<string>();
            foreach (var property in (schema.Value.Properties ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(x => x.Key, StringComparer.Ordinal))
            {
                if ((property.Value.AllOf?.Count ?? 0) == 1)
                {
                    var firstAllOfSchema = property.Value.AllOf!.First();
                    propertiesToAdd.Add(new KeyValuePair<string, IOpenApiSchema>(property.Key, firstAllOfSchema));
                    propertiesToRemove.Add(property.Key);
                }
            }

            foreach (var propertyKey in propertiesToRemove)
            {
                schema.Value.Properties?.Remove(propertyKey);
            }
            foreach (var property in propertiesToAdd)
            {
                schema.Value.Properties?.Add(property.Key, property.Value);
            }
        }

        return openApiDocument;
    }
    
    public static OpenApiDocument ComputeDiscriminators(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        var componentSchemas = (openApiDocument.Components?.Schemas ?? new Dictionary<string, IOpenApiSchema>())
            .OrderBy(x => x.Key, StringComparer.Ordinal)
            .ToArray();
        var componentSchemaIdentities = new HashSet<IOpenApiSchema>(SchemaReferenceEqualityComparer.Instance);
        foreach (var schema in componentSchemas)
        {
            componentSchemaIdentities.Add((IOpenApiSchema?)schema.Value.ResolveSchema() ?? schema.Value);
        }

        var visitedSchemas = new HashSet<IOpenApiSchema>(SchemaReferenceEqualityComparer.Instance);
        foreach (var schema in componentSchemas)
        {
            ProcessSchema(schema.Value, depth: 0, componentSchemaIdentities, visitedSchemas);
        }
        
        return openApiDocument;
    }
    
    public static OpenApiDocument AddMissingPathParameters(
        this OpenApiDocument openApiDocument)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        foreach (var path in openApiDocument.Paths ?? new OpenApiPaths())
        {
            foreach (var operation in path.Value.Operations ?? new Dictionary<System.Net.Http.HttpMethod, OpenApiOperation>())
            {
                var parametersFromPath = PathHelper.ExtractParameters(path.Key.AsSpan());
                var parametersFromSpec = (operation.Value.Parameters ?? new List<IOpenApiParameter>())
                    .Where(x => x.In == ParameterLocation.Path)
                    .Select(x => x.Name)
                    .ToImmutableHashSet();
                foreach (var parameter in parametersFromPath)
                {
                    if (!parametersFromSpec.Contains(parameter))
                    {
                        (operation.Value.Parameters ??= new List<IOpenApiParameter>()).Add(new OpenApiParameter
                        {
                            Name = parameter,
                            In = ParameterLocation.Path,
                            Required = true,
                            Description = "This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
                            Schema = new OpenApiSchema
                            {
                                Type = JsonSchemaType.String,
                            },
                        });
                        
                        Console.WriteLine($"Missing path parameter '{parameter}' was added to operation '{operation.Key}' in path '{path.Key}'.");
                    }
                }
            }
        }
        
        return openApiDocument;
    }

    private static void ProcessSchema(
        IOpenApiSchema schema,
        int depth,
        ISet<IOpenApiSchema> componentSchemaIdentities,
        HashSet<IOpenApiSchema> visitedSchemas)
    {
        if (depth > 10)
        {
            return;
        }

        var schemaIdentity = schema is OpenApiSchemaReference schemaReference &&
                             !HasDiscriminatorTraversalOverrides(schemaReference)
            ? (IOpenApiSchema?)schema.ResolveSchema() ?? schema
            : schema;
        if (depth > 0 && componentSchemaIdentities.Contains(schemaIdentity))
        {
            return;
        }
        if (!visitedSchemas.Add(schemaIdentity))
        {
            return;
        }

        if (schema.Properties is { } properties)
        {
            foreach (var property in properties)
            {
                ProcessSchema(property.Value, depth: depth + 1, componentSchemaIdentities, visitedSchemas);
            }
        }

        // Remove any nested OneOfs
        List<IOpenApiSchema>? schemasToRemove = null;
        List<IOpenApiSchema>? schemasToAdd = null;
        foreach (var value in schema.OneOf ?? [])
        {
            if (value.OneOf is not { Count: > 0 } nestedOneOf)
            {
                continue;
            }

            schemasToAdd ??= [];
            schemasToAdd.AddRange(nestedOneOf);
            (schemasToRemove ??= []).Add(value);
        }
        if (schemasToRemove != null)
        {
            foreach (var schemaToRemove in schemasToRemove)
            {
                schema.OneOf?.Remove(schemaToRemove);
            }
        }
        if (schemasToAdd != null)
        {
            foreach (var schemaToAdd in schemasToAdd)
            {
                schema.OneOf?.Add(schemaToAdd);
            }
        }

        foreach (var value in schema.OneOf ?? [])
        {
            ProcessSchema(value, depth: depth + 1, componentSchemaIdentities, visitedSchemas);
        }
        foreach (var value in schema.AllOf ?? [])
        {
            ProcessSchema(value, depth: depth + 1, componentSchemaIdentities, visitedSchemas);
        }
        foreach (var value in schema.AnyOf ?? [])
        {
            ProcessSchema(value, depth: depth + 1, componentSchemaIdentities, visitedSchemas);
        }
        if (schema.Items != null)
        {
            ProcessSchema(schema.Items, depth: depth + 1, componentSchemaIdentities, visitedSchemas);
        }

        // Auto-detection in OpenAI-like specs
        if (schema.Discriminator == null &&
            (schema.OneOf?.Count ?? 0) > 1 &&
            schema.OneOf!.All(y => (y.ResolveIfRequired().Properties ?? new Dictionary<string, IOpenApiSchema>()).Any(z => z.Value.Enum is { Count: 1 })))
        {
            var oneOfSchemas = schema.OneOf!;
            var discriminatorPropertyName = (oneOfSchemas.First().Properties ?? new Dictionary<string, IOpenApiSchema>())
                .FirstOrDefault(y => y.Value.Enum is { Count: 1 }).Key;
            var uniqueKeys = new HashSet<string>(oneOfSchemas
                .Where(x => (x.Properties ?? new Dictionary<string, IOpenApiSchema>()).ContainsKey(discriminatorPropertyName ?? string.Empty))
                .Select(x => (x.Properties ?? new Dictionary<string, IOpenApiSchema>())[discriminatorPropertyName!].Enum?.FirstOrDefault()?.GetString() ?? string.Empty));
            if (discriminatorPropertyName != null && uniqueKeys.Count == oneOfSchemas.Count)
            {
                // Old Code for Microsoft.OpenApi 1.x
                // schema.Discriminator = new OpenApiDiscriminator
                // {
                //     PropertyName = discriminatorPropertyName,
                //     Mapping = new HashSet<(string Key, string Path)>(schema.OneOf
                //             .Select((x, i) => (
                //                 x.Properties[discriminatorPropertyName].Enum.First().GetString() ?? string.Empty,
                //                 x.Reference?.Id != null ? $"#/components/schemas/{x.Reference?.Id}" : path + "/oneOf/" + i))
                //             .Where(x => !string.IsNullOrWhiteSpace(x.Item1)))
                //         .ToDictionary(x => x.Key, x => x.Path),
                // };

                if (schema.ResolveSchema() is { } resolvedSchema)
                {
                    // Note: In OpenAPI 3.0+, Mapping is IDictionary<string, OpenApiSchemaReference>
                    // Creating proper references requires document context which we don't have here
                    // The discriminator property name is still set, which is the most important part
                    resolvedSchema.Discriminator = new OpenApiDiscriminator
                    {
                        PropertyName = discriminatorPropertyName,
                        // Mapping would require OpenApiSchemaReference objects with document context
                    };
                }
            }
        }
    }

    private static bool HasDiscriminatorTraversalOverrides(OpenApiSchemaReference schemaReference)
    {
        var reference = schemaReference.Reference;
        return reference?.Properties != null ||
               reference?.OneOf != null ||
               reference?.AllOf != null ||
               reference?.AnyOf != null ||
               reference?.Items != null ||
               reference?.Discriminator != null;
    }

    /// <summary>
    /// OpenAPI doesn't allow metadata for references so sometimes allOf with single item is used to add metadata.
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool HasAllOfTypeForMetadata(
        this SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        return context.Schema.HasAllOfTypeForMetadata(propertyName: context.PropertyName);
    }

    /// <summary>
    /// OpenAPI doesn't allow metadata for references so sometimes allOf with single item is used to add metadata.
    /// </summary>
    /// <param name="schema"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static bool HasAllOfTypeForMetadata(
        this IOpenApiSchema schema,
        string? propertyName)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));
        
        return propertyName is not null &&
               (schema.AnyOf?.Count == 1 ||
               schema.AllOf?.Count == 1 ||
               schema.OneOf?.Count == 1) &&
               (schema.Properties?.Count ?? 0) == 0;
    }
    
    public static string GetSummary(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        // Use x-label as fallback when description is missing
        var description = schema.Description;
        if (string.IsNullOrWhiteSpace(description) &&
            TryGetExtensionStringValue(schema.Extensions, "x-label", out var label) &&
            !string.IsNullOrWhiteSpace(label))
        {
            description = label;
        }

        // Remove any XML tags from the description
        var summary = description?.ClearForXml() ?? string.Empty;
        var @default = schema.Default.GetString()?.ClearForXml();
        if (!string.IsNullOrWhiteSpace(@default))
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }

            summary += $"Default Value: {@default}";
        }
        
        if (schema.ReadOnly)
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }

            summary += "Included only in responses";
        }
        if (schema.WriteOnly)
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }

            summary += "Included only in requests";
        }

        var example = schema.GetLegacyExample().GetString()?.ClearForXml();
        if (!string.IsNullOrWhiteSpace(example))
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }

            summary += $"Example: {example}";
        }

        return summary;
    }

    public static string GetXmlDocumentationSummary(this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        // Remove any XML tags from the description
        var summary = operation.Summary?.ClearForXml() ?? string.Empty;
        var description = operation.Description?.ClearForXml();
        if (!string.IsNullOrWhiteSpace(description))
        {
            if (!string.IsNullOrWhiteSpace(summary))
            {
                summary += "\n";
            }
            
            summary += $"{description}";
        }

        return summary;
    }

    public static string GetExperimentalStage(this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (TryGetExtensionString(operation.Extensions, "x-stage", out var stageString))
        {
            return NormalizeExperimentalStage(stageString);
        }

        if (TryGetExtensionBoolean(operation.Extensions, "x-alpha"))
        {
            return "Alpha";
        }

        if (TryGetExtensionBoolean(operation.Extensions, "x-beta"))
        {
            return "Beta";
        }

        if (TryGetAvailability(operation.Extensions, out var availability))
        {
            return NormalizeExperimentalStage(availability);
        }

        return GetExperimentalStageFromSummary(operation.Summary);
    }

    public static IReadOnlyList<IdempotencyHeader> GetDocumentIdempotencyHeaders(
        IDictionary<string, IOpenApiExtension>? extensions)
    {
        if (!(extensions?.TryGetValue("x-fern-idempotency-headers", out var extension) ?? false) ||
            TryGetExtensionJsonNode(extension) is not JsonArray headersArray ||
            headersArray.Count == 0)
        {
            return [];
        }

        var headers = new List<IdempotencyHeader>(headersArray.Count);
        foreach (var item in headersArray)
        {
            switch (item)
            {
                case JsonValue value when value.TryGetValue<string>(out var headerValue) &&
                                          !string.IsNullOrWhiteSpace(headerValue):
                    headers.Add(new IdempotencyHeader(
                        headerValue,
                        headerValue));
                    break;

                case JsonObject headerObject
                    when TryGetJsonObjectString(headerObject, out var headerName, "header") &&
                         !string.IsNullOrWhiteSpace(headerName):
                    headers.Add(new IdempotencyHeader(
                        headerName,
                        TryGetJsonObjectString(headerObject, out var parameterName, "name") &&
                        !string.IsNullOrWhiteSpace(parameterName)
                            ? parameterName
                            : headerName));
                    break;
            }
        }

        return headers;
    }

    public static bool IsIdempotentOperation(IDictionary<string, IOpenApiExtension>? extensions)
    {
        // x-idempotency is the Stripe-style spec extension; x-fern-idempotent is the legacy Fern equivalent.
        return GetExtensionBooleanValue(extensions, "x-fern-idempotent") ||
               GetExtensionBooleanValue(extensions, "x-idempotency");
    }

    public static bool TryGetOperationGroupNameOverride(
        IDictionary<string, IOpenApiExtension>? extensions,
        out string value)
    {
        if (TryGetExtensionString(extensions, "x-fern-sdk-group-name", out value))
        {
            return true;
        }

        if (TryGetExtensionString(extensions, "x-speakeasy-group", out value))
        {
            return true;
        }

        value = string.Empty;
        return false;
    }

    public static EquatableArray<PollingOperation> GetPollingOperations(
        this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (!(operation.Extensions?.TryGetValue("x-speakeasy-polling", out var extension) ?? false))
        {
            return ImmutableArray<PollingOperation>.Empty.AsEquatableArray();
        }

        var node = TryGetExtensionJsonNode(extension);
        var items = node switch
        {
            JsonArray array => array,
            JsonObject singleObject => new JsonArray(singleObject),
            _ => null,
        };
        if (items == null)
        {
            return ImmutableArray<PollingOperation>.Empty.AsEquatableArray();
        }

        var operations = new List<PollingOperation>();

        foreach (var item in items)
        {
            if (item is not JsonObject objectNode ||
                !TryGetJsonObjectString(objectNode, out var name, "name"))
            {
                continue;
            }

            var successCriteria = ParsePollingCriteria(objectNode, "successCriteria");
            if (successCriteria.IsEmpty)
            {
                continue;
            }

            operations.Add(PollingOperation.Default with
            {
                Name = name,
                DelaySeconds = TryGetJsonObjectInt(objectNode, out var delaySeconds, "delaySeconds")
                    ? Math.Max(delaySeconds, 0)
                    : PollingOperation.Default.DelaySeconds,
                IntervalSeconds = TryGetJsonObjectInt(objectNode, out var intervalSeconds, "intervalSeconds")
                    ? Math.Max(intervalSeconds, 0)
                    : PollingOperation.Default.IntervalSeconds,
                LimitCount = TryGetJsonObjectInt(objectNode, out var limitCount, "limitCount")
                    ? Math.Max(limitCount, 1)
                    : PollingOperation.Default.LimitCount,
                SuccessCriteria = successCriteria,
                FailureCriteria = ParsePollingCriteria(objectNode, "failureCriteria"),
            });
        }

        return operations.ToImmutableArray().AsEquatableArray();
    }

    private static readonly HashSet<string> SuccessTerminalStatusValues = new(StringComparer.OrdinalIgnoreCase)
    {
        "success", "succeeded", "complete", "completed", "done", "finished",
    };

    private static readonly HashSet<string> FailureTerminalStatusValues = new(StringComparer.OrdinalIgnoreCase)
    {
        "error", "errored", "failed", "failure",
    };

    private static readonly HashSet<string> CancelTerminalStatusValues = new(StringComparer.OrdinalIgnoreCase)
    {
        "aborted", "cancelled", "canceled",
    };

    /// <summary>
    /// Detects status-based polling automatically when an operation returns a schema (or oneOf union of schemas)
    /// with a discriminator-shaped <c>status</c> property whose values include at least one known terminal-success
    /// state (succeeded/completed/done/finished). Terminal failures (failed/errored/canceled/...) become failure criteria.
    /// </summary>
    public static EquatableArray<PollingOperation> AutoDetectStatusPollingOperations(
        this OpenApiOperation operation,
        System.Net.Http.HttpMethod operationType)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (operationType != System.Net.Http.HttpMethod.Get)
        {
            return ImmutableArray<PollingOperation>.Empty.AsEquatableArray();
        }

        var responses = operation.Responses;
        if (responses == null || responses.Count == 0)
        {
            return ImmutableArray<PollingOperation>.Empty.AsEquatableArray();
        }

        IOpenApiResponse? successResponse = null;
        foreach (var pair in responses)
        {
            if (string.Equals(pair.Key, "default", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            if (pair.Key is { Length: 3 } key && key[0] == '2')
            {
                successResponse = pair.Value;
                break;
            }
        }

        if (successResponse?.Content == null || successResponse.Content.Count == 0)
        {
            return ImmutableArray<PollingOperation>.Empty.AsEquatableArray();
        }

        IOpenApiSchema? schema = successResponse.Content.Values
            .Select(static x => x?.Schema)
            .FirstOrDefault(static s => s != null);
        if (schema is null)
        {
            return ImmutableArray<PollingOperation>.Empty.AsEquatableArray();
        }

        var statusValues = CollectStatusValues(schema, depth: 0);
        if (statusValues.Count == 0)
        {
            return ImmutableArray<PollingOperation>.Empty.AsEquatableArray();
        }

        var successHits = new List<string>();
        var failureHits = new List<string>();
        foreach (var value in statusValues)
        {
            if (SuccessTerminalStatusValues.Contains(value))
            {
                successHits.Add(value);
            }
            else if (FailureTerminalStatusValues.Contains(value) ||
                     CancelTerminalStatusValues.Contains(value))
            {
                failureHits.Add(value);
            }
        }

        if (successHits.Count == 0)
        {
            return ImmutableArray<PollingOperation>.Empty.AsEquatableArray();
        }

        static string BuildStatusPattern(IEnumerable<string> values)
        {
            var alternatives = string.Join("|", values.Select(System.Text.RegularExpressions.Regex.Escape));
            return $"^(?i)({alternatives})$";
        }

        var successCriterion = new PollingCriterion(
            Type: PollingCriterionType.Regex,
            ContextType: PollingCriterionContextType.ResponseBody,
            JsonPointer: "/status",
            Operator: string.Empty,
            ExpectedValue: string.Empty,
            Pattern: BuildStatusPattern(successHits));

        var operations = new List<PollingCriterion> { successCriterion }.ToImmutableArray().AsEquatableArray();
        var failureOperations = failureHits.Count == 0
            ? ImmutableArray<PollingCriterion>.Empty.AsEquatableArray()
            : new List<PollingCriterion>
            {
                new(
                    Type: PollingCriterionType.Regex,
                    ContextType: PollingCriterionContextType.ResponseBody,
                    JsonPointer: "/status",
                    Operator: string.Empty,
                    ExpectedValue: string.Empty,
                    Pattern: BuildStatusPattern(failureHits)),
            }.ToImmutableArray().AsEquatableArray();

        var pollingOperation = PollingOperation.Default with
        {
            Name = "Wait",
            DelaySeconds = 1,
            IntervalSeconds = 2,
            LimitCount = 60,
            SuccessCriteria = operations,
            FailureCriteria = failureOperations,
        };

        return new[] { pollingOperation }.ToImmutableArray().AsEquatableArray();
    }

    private static HashSet<string> CollectStatusValues(IOpenApiSchema schema, int depth)
    {
        var values = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        CollectStatusValuesCore(schema, values, depth);
        return values;
    }

    private static void CollectStatusValuesCore(
        IOpenApiSchema? schema,
        HashSet<string> values,
        int depth)
    {
        if (schema == null || depth > 5)
        {
            return;
        }

        if (schema is OpenApiSchemaReference { Target: { } target })
        {
            schema = target;
        }

        if ((schema.OneOf is { Count: > 0 } || schema.AnyOf is { Count: > 0 }) &&
            schema.Discriminator?.PropertyName is { } discriminatorProperty &&
            string.Equals(discriminatorProperty, "status", StringComparison.OrdinalIgnoreCase))
        {
            var unionVariants = (IEnumerable<IOpenApiSchema>?)schema.OneOf ?? schema.AnyOf;
            if (unionVariants != null)
            {
                foreach (var variant in unionVariants)
                {
                    CollectStatusValuesCore(variant, values, depth + 1);
                }
            }

            return;
        }

        if (schema.Properties is { } properties)
        {
            foreach (var pair in properties)
            {
                if (!string.Equals(pair.Key, "status", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                CollectStatusFromProperty(pair.Value, values);
                return;
            }
        }

        if (schema.AllOf is { Count: > 0 } allOf)
        {
            foreach (var part in allOf)
            {
                CollectStatusValuesCore(part, values, depth + 1);
            }
        }
    }

    private static void CollectStatusFromProperty(IOpenApiSchema? schema, HashSet<string> values)
    {
        if (schema == null)
        {
            return;
        }

        if (!string.IsNullOrWhiteSpace(schema.Const))
        {
            values.Add(schema.Const!);
            return;
        }

        if (schema.Enum is { Count: > 0 } enumValues)
        {
            foreach (var item in enumValues)
            {
                var enumString = item?.GetString();
                if (!string.IsNullOrWhiteSpace(enumString))
                {
                    values.Add(enumString!);
                }
            }
        }
    }

    public static bool TryGetMethodNameOverride(
        IDictionary<string, IOpenApiExtension>? extensions,
        out string value)
    {
        if (TryGetExtensionString(extensions, "x-fern-sdk-method-name", out value))
        {
            return true;
        }

        if ((extensions?.TryGetValue("x-oaiMeta", out var oaiMetaExt) ?? false) &&
            TryGetExtensionJsonNode(oaiMetaExt) is JsonObject oaiMetaObj &&
            TryGetJsonObjectString(oaiMetaObj, out value, "name"))
        {
            return true;
        }

        if (TryGetExtensionString(extensions, "x-speakeasy-name-override", out value))
        {
            return true;
        }

        return TryGetLanguageSpecificExtensionString(
            extensions,
            "x-stainless-naming",
            out value,
            "method_name",
            "name");
    }

    public static bool TryGetTypeNameOverride(
        IDictionary<string, IOpenApiExtension>? extensions,
        out string value)
    {
        if (TryGetExtensionString(extensions, "x-fern-type-name", out value))
        {
            return true;
        }

        if (TryGetExtensionString(extensions, "x-speakeasy-name-override", out value))
        {
            return true;
        }

        return TryGetLanguageSpecificExtensionString(
            extensions,
            "x-stainless-naming",
            out value,
            "model_name",
            "type_name",
            "name");
    }

    public static bool TryGetPropertyNameOverride(
        IDictionary<string, IOpenApiExtension>? extensions,
        out string value)
    {
        if (TryGetExtensionString(extensions, "x-speakeasy-name-override", out value))
        {
            return true;
        }

        return TryGetLanguageSpecificExtensionString(
            extensions,
            "x-stainless-naming",
            out value,
            "property_name",
            "parameter_name",
            "name");
    }

    public static bool TryGetParameterNameOverride(
        IDictionary<string, IOpenApiExtension>? parameterExtensions,
        IDictionary<string, IOpenApiExtension>? schemaExtensions,
        out string value)
    {
        if (TryGetPropertyNameOverride(parameterExtensions, out value))
        {
            return true;
        }

        return TryGetPropertyNameOverride(schemaExtensions, out value);
    }

    public static bool ShouldIgnoreOperationForDotNet(IDictionary<string, IOpenApiExtension>? extensions)
    {
        return GetExtensionBooleanValue(extensions, "x-fern-ignore") ||
               GetExtensionBooleanValue(extensions, "x-hidden") ||
               GetExtensionBooleanValue(extensions, "x-speakeasy-ignore") ||
               HasLanguageSkipExtension(extensions, "x-stainless-skip");
    }

    public static bool IsDeprecated(this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        return operation.Deprecated ||
               TryGetAvailability(operation.Extensions, out var availability) &&
               string.Equals(availability, "Deprecated", StringComparison.Ordinal);
    }

    public static bool IsDeprecated(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        return schema.Deprecated ||
               TryGetAvailability(schema.Extensions, out var availability) &&
               string.Equals(availability, "Deprecated", StringComparison.Ordinal);
    }

    /// <summary>
    /// Gets a custom deprecation message from x-stainless-deprecation-message extension.
    /// </summary>
    public static string GetDeprecationMessage(this OpenApiOperation operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (TryGetExtensionString(operation.Extensions, "x-stainless-deprecation-message", out var message))
        {
            return message;
        }

        if (TryGetExtensionString(operation.Extensions, "x-speakeasy-deprecation-message", out message))
        {
            return message;
        }

        return string.Empty;
    }

    /// <summary>
    /// Gets a custom deprecation message from x-stainless-deprecation-message extension on a schema.
    /// </summary>
    public static string GetDeprecationMessage(this IOpenApiSchema schema)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        if (TryGetExtensionString(schema.Extensions, "x-stainless-deprecation-message", out var message))
        {
            return message;
        }

        if (TryGetExtensionString(schema.Extensions, "x-speakeasy-deprecation-message", out message))
        {
            return message;
        }

        return string.Empty;
    }

    public static string GetExperimentalStageFromSummary(this string? summary)
    {
        if (string.IsNullOrWhiteSpace(summary))
        {
            return string.Empty;
        }

        var trimmed = summary!.TrimStart();

        foreach (var (prefix, stage) in ExperimentalStagePrefixes)
        {
            if (trimmed.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                return stage;
            }
        }

        return string.Empty;
    }

    public static string StripExperimentalStagePrefix(this string? summary)
    {
        if (string.IsNullOrWhiteSpace(summary))
        {
            return string.Empty;
        }

        var trimmed = summary!.Trim();

        foreach (var (prefix, _) in ExperimentalStagePrefixes)
        {
            if (!trimmed.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var remainder = trimmed.Substring(prefix.Length).TrimStart(' ', '\t', ':', '-', '_');
            return string.IsNullOrWhiteSpace(remainder) ? trimmed : remainder;
        }

        return trimmed;
    }

    public static string ClearForXml(this string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        return text
            .Replace("\r\n", "\n")
            .Replace("<br>", string.Empty)
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;");
    }

    public static string ClearForCSharp(this string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));

        return text
            .Replace("\"", "\"\"")
            .Trim();
    }

    public static string? GetString(this JsonNode? any)
    {
        if (any == null)
        {
            return null;
        }

        return any switch
        {
            // Old Code for Microsoft.OpenApi 1.x
            //OpenApiObject @object => $"{{{string.Join(", ", @object.Select(x => $"{x.Key}: {GetString(x.Value)}"))}}}",


            JsonValue value when value.TryGetValue<string>(out var s) => string.IsNullOrWhiteSpace(s) ? null : s,
            JsonValue value when value.TryGetValue<int>(out var i) => i.ToString(CultureInfo.InvariantCulture),
            JsonValue value when value.TryGetValue<long>(out var l) => l.ToString(CultureInfo.InvariantCulture) + "L",
            JsonValue value when value.TryGetValue<float>(out var f) => f.ToString(CultureInfo.InvariantCulture) + "F",
            JsonValue value when value.TryGetValue<double>(out var d) => d.ToString(CultureInfo.InvariantCulture),
            JsonValue value when value.TryGetValue<bool>(out var b) => b ? "true" : "false",
            JsonArray array => $"[{string.Join(", ", array.Select(GetString))}]",
            _ => any.ToJsonString(),
        };
    }

    public static KeyValuePair<string, IOpenApiSchema> WithKey(
        this IOpenApiSchema schema,
        string key)
    {
        return new KeyValuePair<string, IOpenApiSchema>(key, schema);
    }

    public static string ReplacePlusAndMinusOnStart(
        this string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        
        text = text.StartsWith("-", StringComparison.Ordinal)
            ? "Minus" + text.TrimStart('-')
            : text;
        text = text.StartsWith("+", StringComparison.Ordinal)
            ? "Plus" + text.TrimStart('+')
            : text;

        return text;
    }
    
    private static readonly (string Prefix, string Stage)[] ExperimentalStagePrefixes =
    [
        ("[Alpha]", "Alpha"),
        ("[Beta]", "Beta"),
        ("[Experimental]", "Experimental"),
        ("Alpha", "Alpha"),
        ("Beta", "Beta"),
        ("Experimental", "Experimental"),
    ];

    private static readonly string[] DotNetLanguageKeys =
    [
        "csharp",
        "c#",
        "dotnet",
        ".net",
        "net",
    ];

    private static string NormalizeExperimentalStage(string? stage)
    {
        var normalized = stage?.Trim() ?? string.Empty;
        if (normalized.Length == 0)
        {
            return string.Empty;
        }

        if (normalized.Equals("Alpha", StringComparison.OrdinalIgnoreCase)) return "Alpha";
        if (normalized.Equals("Beta", StringComparison.OrdinalIgnoreCase)) return "Beta";
        if (normalized.Equals("Experimental", StringComparison.OrdinalIgnoreCase)) return "Experimental";
        if (normalized.Equals("Generally-Available", StringComparison.OrdinalIgnoreCase)) return string.Empty;
        if (normalized.Equals("Deprecated", StringComparison.OrdinalIgnoreCase)) return string.Empty;
        return normalized;
    }

    private static string NormalizeAvailability(string? availability)
    {
        var normalized = availability?.Trim() ?? string.Empty;
        if (normalized.Length == 0)
        {
            return string.Empty;
        }

        if (normalized.Equals("Alpha", StringComparison.OrdinalIgnoreCase)) return "Alpha";
        if (normalized.Equals("Beta", StringComparison.OrdinalIgnoreCase)) return "Beta";
        if (normalized.Equals("Deprecated", StringComparison.OrdinalIgnoreCase)) return "Deprecated";
        if (normalized.Equals("Generally-Available", StringComparison.OrdinalIgnoreCase)) return "GenerallyAvailable";
        return normalized;
    }

    private static bool TryGetAvailability(IDictionary<string, IOpenApiExtension>? extensions, out string availability)
    {
        availability = string.Empty;

        if (!TryGetExtensionString(extensions, "x-fern-availability", out var rawAvailability))
        {
            return false;
        }

        availability = NormalizeAvailability(rawAvailability);
        return !string.IsNullOrWhiteSpace(availability);
    }

    private static bool HasLanguageSkipExtension(
        IDictionary<string, IOpenApiExtension>? extensions,
        string extensionName)
    {
        if (!(extensions?.TryGetValue(extensionName, out var extension) ?? false))
        {
            return false;
        }

        var node = TryGetExtensionJsonNode(extension);
        if (node is JsonArray array)
        {
            foreach (var item in array)
            {
                if (item is JsonValue value &&
                    value.TryGetValue<string>(out var language) &&
                    DotNetLanguageKeys.Any(x => string.Equals(x, language, StringComparison.OrdinalIgnoreCase)))
                {
                    return true;
                }
            }

            return false;
        }

        return node is JsonValue singleValue &&
               singleValue.TryGetValue<string>(out var singleLanguage) &&
               DotNetLanguageKeys.Any(x => string.Equals(x, singleLanguage, StringComparison.OrdinalIgnoreCase));
    }

    private static bool TryGetLanguageSpecificExtensionString(
        IDictionary<string, IOpenApiExtension>? extensions,
        string extensionName,
        out string value,
        params string[] propertyNames)
    {
        value = string.Empty;

        if (!(extensions?.TryGetValue(extensionName, out var extension) ?? false) ||
            TryGetExtensionJsonNode(extension) is not JsonObject extensionObject)
        {
            return false;
        }

        foreach (var languageKey in DotNetLanguageKeys)
        {
            if (!TryGetJsonObjectProperty(extensionObject, languageKey, out var languageNode) ||
                languageNode is not JsonObject languageObject)
            {
                continue;
            }

            if (TryGetJsonObjectString(languageObject, out value, propertyNames))
            {
                return true;
            }
        }

        return TryGetJsonObjectString(extensionObject, out value, propertyNames);
    }

    private static bool TryGetExtensionString(
        IDictionary<string, IOpenApiExtension>? extensions,
        string name,
        out string value)
    {
        value = string.Empty;

        if (!(extensions?.TryGetValue(name, out var extension) ?? false))
        {
            return false;
        }

        if (TryGetJsonString(extension, out var stringValue))
        {
            value = stringValue;
            return true;
        }

        return false;
    }

    private static bool TryGetExtensionBoolean(
        IDictionary<string, IOpenApiExtension>? extensions,
        string name)
    {
        if (!(extensions?.TryGetValue(name, out var extension) ?? false))
        {
            return false;
        }

        return TryGetJsonBoolean(extension, out var booleanValue) && booleanValue;
    }

    private static bool TryGetJsonString(IOpenApiExtension extension, out string value)
    {
        value = string.Empty;

        var node = extension switch
        {
            JsonValue jsonValue => jsonValue,
            JsonNodeExtension jsonNodeExtension => jsonNodeExtension.Node,
            _ => null,
        };

        if (node is JsonValue stringNode &&
            stringNode.TryGetValue<string>(out var stringValue) &&
            !string.IsNullOrWhiteSpace(stringValue))
        {
            value = stringValue;
            return true;
        }

        return false;
    }

    private static bool TryGetJsonObjectString(
        JsonObject jsonObject,
        out string value,
        params string[] propertyNames)
    {
        value = string.Empty;

        foreach (var propertyName in propertyNames)
        {
            if (!TryGetJsonObjectProperty(jsonObject, propertyName, out var node) ||
                node is not JsonValue jsonValue ||
                !jsonValue.TryGetValue<string>(out var stringValue) ||
                string.IsNullOrWhiteSpace(stringValue))
            {
                continue;
            }

            value = stringValue;
            return true;
        }

        return false;
    }

    private static bool TryGetJsonObjectInt(
        JsonObject jsonObject,
        out int value,
        params string[] propertyNames)
    {
        value = 0;

        foreach (var propertyName in propertyNames)
        {
            if (!TryGetJsonObjectProperty(jsonObject, propertyName, out var node) ||
                node is not JsonValue jsonValue)
            {
                continue;
            }

            if (jsonValue.TryGetValue<int>(out value))
            {
                return true;
            }

            if (jsonValue.TryGetValue<long>(out var longValue) &&
                longValue is >= int.MinValue and <= int.MaxValue)
            {
                value = (int)longValue;
                return true;
            }

            if (jsonValue.TryGetValue<double>(out var doubleValue) &&
                doubleValue >= int.MinValue &&
                doubleValue <= int.MaxValue &&
                Math.Abs(doubleValue % 1d) < double.Epsilon)
            {
                value = (int)doubleValue;
                return true;
            }

            if (jsonValue.TryGetValue<decimal>(out var decimalValue) &&
                decimalValue >= int.MinValue &&
                decimalValue <= int.MaxValue &&
                decimal.Truncate(decimalValue) == decimalValue)
            {
                value = (int)decimalValue;
                return true;
            }

            if (jsonValue.TryGetValue<string>(out var stringValue) &&
                int.TryParse(stringValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
            {
                return true;
            }
        }

        return false;
    }

    private static bool TryGetJsonObjectProperty(
        JsonObject jsonObject,
        string propertyName,
        out JsonNode? value)
    {
        foreach (var kvp in jsonObject)
        {
            if (!string.Equals(kvp.Key, propertyName, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            value = kvp.Value;
            return value != null;
        }

        value = null;
        return false;
    }

    private static bool TryGetJsonBoolean(IOpenApiExtension extension, out bool value)
    {
        value = false;

        var node = extension switch
        {
            JsonValue jsonValue => jsonValue,
            JsonNodeExtension jsonNodeExtension => jsonNodeExtension.Node,
            _ => null,
        };

        if (node is JsonValue booleanNode &&
            booleanNode.TryGetValue<bool>(out var booleanValue))
        {
            value = booleanValue;
            return true;
        }

        return false;
    }

    private static EquatableArray<PollingCriterion> ParsePollingCriteria(
        JsonObject jsonObject,
        string propertyName)
    {
        if (!TryGetJsonObjectProperty(jsonObject, propertyName, out var node) ||
            node is not JsonArray criteriaArray)
        {
            return ImmutableArray<PollingCriterion>.Empty.AsEquatableArray();
        }

        var criteria = new List<PollingCriterion>();

        foreach (var item in criteriaArray)
        {
            if (item is not JsonObject criterionObject)
            {
                continue;
            }

            var type = TryGetJsonObjectString(criterionObject, out var rawType, "type") &&
                       string.Equals(rawType, "regex", StringComparison.OrdinalIgnoreCase)
                ? PollingCriterionType.Regex
                : PollingCriterionType.Simple;

            if (type == PollingCriterionType.Regex)
            {
                if (!TryGetJsonObjectString(criterionObject, out var context, "context") ||
                    !TryGetJsonObjectString(criterionObject, out var pattern, "condition") ||
                    !TryParsePollingContext(context, out var contextType, out var jsonPointer))
                {
                    continue;
                }

                criteria.Add(PollingCriterion.Default with
                {
                    Type = PollingCriterionType.Regex,
                    ContextType = contextType,
                    JsonPointer = jsonPointer,
                    Pattern = pattern,
                });
                continue;
            }

            if (!TryGetJsonObjectString(criterionObject, out var condition, "condition") ||
                !TryParseSimplePollingCondition(
                    condition,
                    out var simpleContextType,
                    out var simpleJsonPointer,
                    out var @operator,
                    out var expectedValue))
            {
                continue;
            }

            criteria.Add(PollingCriterion.Default with
            {
                Type = PollingCriterionType.Simple,
                ContextType = simpleContextType,
                JsonPointer = simpleJsonPointer,
                Operator = @operator,
                ExpectedValue = expectedValue,
            });
        }

        return criteria.ToImmutableArray().AsEquatableArray();
    }

    private static bool TryParseSimplePollingCondition(
        string condition,
        out PollingCriterionContextType contextType,
        out string jsonPointer,
        out string @operator,
        out string expectedValue)
    {
        contextType = PollingCriterionContextType.StatusCode;
        jsonPointer = string.Empty;
        @operator = string.Empty;
        expectedValue = string.Empty;

        condition = condition?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(condition))
        {
            return false;
        }

        var operatorIndex = condition.IndexOf("==", StringComparison.Ordinal);
        if (operatorIndex >= 0)
        {
            @operator = "==";
        }
        else
        {
            operatorIndex = condition.IndexOf("!=", StringComparison.Ordinal);
            if (operatorIndex >= 0)
            {
                @operator = "!=";
            }
        }

        if (operatorIndex < 0)
        {
            return false;
        }

        var context = condition.Substring(0, operatorIndex).Trim();
        var value = condition.Substring(operatorIndex + 2).Trim();
        return TryParsePollingContext(context, out contextType, out jsonPointer) &&
               TryNormalizePollingLiteral(value, out expectedValue);
    }

    private static bool TryParsePollingContext(
        string context,
        out PollingCriterionContextType contextType,
        out string jsonPointer)
    {
        contextType = PollingCriterionContextType.StatusCode;
        jsonPointer = string.Empty;

        context = context?.Trim() ?? string.Empty;
        if (string.Equals(context, "$statusCode", StringComparison.Ordinal))
        {
            contextType = PollingCriterionContextType.StatusCode;
            return true;
        }

        if (!context.StartsWith("$response.body#", StringComparison.Ordinal))
        {
            return false;
        }

        contextType = PollingCriterionContextType.ResponseBody;
        jsonPointer = context.Substring("$response.body#".Length);
        return true;
    }

    private static bool TryNormalizePollingLiteral(string value, out string normalized)
    {
        normalized = string.Empty;
        value = value?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        try
        {
            var node = JsonNode.Parse(value);
            switch (node)
            {
                case null:
                    normalized = "null";
                    return true;
                case JsonValue jsonValue when jsonValue.TryGetValue<string>(out var stringValue):
                    normalized = stringValue;
                    return true;
                case JsonValue jsonValue when jsonValue.TryGetValue<bool>(out var boolValue):
                    normalized = boolValue ? "true" : "false";
                    return true;
                case JsonValue:
                    normalized = node.ToJsonString();
                    return true;
                default:
                    normalized = node.ToJsonString();
                    return true;
            }
        }
        catch (JsonException)
        {
            normalized = value.Trim('"');
            return !string.IsNullOrWhiteSpace(normalized);
        }
    }

    /// <summary>
    /// Public helper to extract a string value from an OpenAPI extension.
    /// Used by naming generators and other extension-processing code.
    /// </summary>
    public static bool TryGetExtensionStringValue(IOpenApiExtension extension, out string value)
    {
        return TryGetJsonString(extension, out value);
    }

    /// <summary>
    /// Public helper to extract a JsonNode from an OpenAPI extension.
    /// </summary>
    public static JsonNode? TryGetExtensionJsonNode(IOpenApiExtension extension)
    {
        return extension switch
        {
            JsonNode jsonNode => jsonNode,
            JsonNodeExtension jsonNodeExtension => jsonNodeExtension.Node,
            _ => null,
        };
    }

    /// <summary>
    /// Public helper to extract a string value from an OpenAPI extensions dictionary by key.
    /// </summary>
    public static bool TryGetExtensionStringValue(
        IDictionary<string, IOpenApiExtension>? extensions,
        string name,
        out string value)
    {
        return TryGetExtensionString(extensions, name, out value);
    }

    /// <summary>
    /// Public helper to check a boolean OpenAPI extension value.
    /// </summary>
    public static bool GetExtensionBooleanValue(
        IDictionary<string, IOpenApiExtension>? extensions,
        string name)
    {
        return TryGetExtensionBoolean(extensions, name);
    }

    public static string[] FindAllOperationIdsForTag(
        this OpenApiDocument openApiDocument,
        string tag)
    {
        openApiDocument = openApiDocument ?? throw new ArgumentNullException(nameof(openApiDocument));
        
        return (openApiDocument.Paths ?? new OpenApiPaths())
            .SelectMany(path => path.Value.Operations ?? new Dictionary<System.Net.Http.HttpMethod, OpenApiOperation>())
            .Where(x => x.Value.Tags?.Any(y => y.Name == tag) != false)
            .Where(x => x.Value.OperationId != null)
            .Select(x => x.Value.OperationId!)
            .ToArray();
    }

    private static string ToInvariantLowercase(string value)
    {
        value = value ?? throw new ArgumentNullException(nameof(value));
        var chars = value.ToCharArray();
        for (var i = 0; i < chars.Length; i++)
        {
            chars[i] = char.ToLowerInvariant(chars[i]);
        }

        return new string(chars);
    }
}
