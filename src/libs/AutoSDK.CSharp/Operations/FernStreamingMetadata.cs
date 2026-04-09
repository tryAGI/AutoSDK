using System.Collections.Immutable;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Models;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

internal sealed class FernStreamingMetadata
{
    public FernStreamingMetadata(
        StreamFormat streamFormat,
        string? terminator,
        bool hasRequestStreamCondition,
        EndPointResponse? regularResponseOverride,
        EndPointResponse? streamResponseOverride)
    {
        StreamFormat = streamFormat;
        Terminator = terminator;
        HasRequestStreamCondition = hasRequestStreamCondition;
        RegularResponseOverride = regularResponseOverride;
        StreamResponseOverride = streamResponseOverride;
    }

    public StreamFormat StreamFormat { get; }

    public string? Terminator { get; }

    public bool HasRequestStreamCondition { get; }

    public EndPointResponse? RegularResponseOverride { get; }

    public EndPointResponse? StreamResponseOverride { get; }

    public static FernStreamingMetadata? TryCreate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (!(operation.Operation.Extensions ?? new Dictionary<string, IOpenApiExtension>())
            .TryGetValue("x-fern-streaming", out var extension))
        {
            return null;
        }

        var successResponse = GetSuccessResponse(operation, preferredMimeType: "application/json");
        var successResponseSchema = GetSuccessResponseSchema(operation, preferredMimeType: "application/json");
        var jsonNode = OpenApiExtensions.TryGetExtensionJsonNode(extension);

        if (jsonNode is JsonValue jsonValue)
        {
            if (!(jsonValue.TryGetValue<bool>(out var isStreaming) && isStreaming) &&
                !bool.TryParse(jsonNode.ToString(), out isStreaming))
            {
                return null;
            }

            if (!isStreaming)
            {
                return null;
            }

            var streamFormat =
                successResponse.MimeType.IsJsonMimeType() ||
                successResponse.MimeType.IsSequentialJsonMimeType()
                    ? StreamFormat.Ndjson
                    : StreamFormat.Binary;

            EndPointResponse? streamResponse = streamFormat == StreamFormat.Binary
                ? CreateResponseOverride(
                    successResponse,
                    CreateBinaryStreamType(operation),
                    streamFormat)
                : null;

            return new FernStreamingMetadata(
                streamFormat: streamFormat,
                terminator: null,
                hasRequestStreamCondition: false,
                regularResponseOverride: null,
                streamResponseOverride: streamResponse);
        }

        if (jsonNode is not JsonObject jsonObject)
        {
            return null;
        }

        var streamFormatFromExtension = ResolveStreamFormat(jsonObject, successResponse);
        var hasRequestStreamCondition = string.Equals(
            TryGetStringValue(jsonObject["stream-condition"]),
            "$request.stream",
            StringComparison.Ordinal);
        var terminator = TryGetStringValue(jsonObject["terminator"]);

        var regularResponseOverride = TryResolveResponseOverride(
            operation,
            jsonObject["response"],
            successResponse,
            successResponseSchema,
            StreamFormat.None);
        var streamResponseOverride = TryResolveResponseOverride(
            operation,
            jsonObject["response-stream"] ?? jsonObject["response"],
            successResponse,
            successResponseSchema,
            streamFormatFromExtension);

        if (hasRequestStreamCondition)
        {
            regularResponseOverride ??= TryCreateComplementResponseOverride(
                operation,
                successResponseSchema,
                streamResponseOverride,
                StreamFormat.None);
            streamResponseOverride ??= TryCreateComplementResponseOverride(
                operation,
                successResponseSchema,
                regularResponseOverride,
                streamFormatFromExtension);
        }

        return new FernStreamingMetadata(
            streamFormat: streamFormatFromExtension,
            terminator: terminator,
            hasRequestStreamCondition: hasRequestStreamCondition,
            regularResponseOverride: regularResponseOverride,
            streamResponseOverride: streamResponseOverride);
    }

    private static EndPointResponse GetSuccessResponse(OperationContext operation, string? preferredMimeType)
    {
        var responses = (operation.Operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            .Select(x => CSharpEndPointResponseFactory.FromResponse(x, operation, preferredMimeType))
            .ToArray();

        return responses.Any(x => x.Is2XX && !string.IsNullOrWhiteSpace(x.Type.CSharpTypeRaw))
            ? responses.First(x => x.Is2XX && !string.IsNullOrWhiteSpace(x.Type.CSharpTypeRaw))
            : responses.Any(x => x.Is2XX)
                ? responses.First(x => x.Is2XX)
                : responses.Any(x => x.IsDefault)
                    ? responses.First(x => x.IsDefault)
                    : EndPointResponse.Default;
    }

    private static StreamFormat ResolveStreamFormat(JsonObject jsonObject, EndPointResponse successResponse)
    {
        var format = TryGetStringValue(jsonObject["format"]);
        if (string.Equals(format, "sse", StringComparison.OrdinalIgnoreCase))
        {
            return StreamFormat.ServerSentEvents;
        }

        if (string.Equals(format, "ndjson", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(format, "json", StringComparison.OrdinalIgnoreCase))
        {
            return StreamFormat.Ndjson;
        }

        return successResponse.MimeType.IsJsonMimeType() ||
               successResponse.MimeType.IsSequentialJsonMimeType()
            ? StreamFormat.Ndjson
            : StreamFormat.Binary;
    }

    private static EndPointResponse? TryResolveResponseOverride(
        OperationContext operation,
        JsonNode? schemaNode,
        EndPointResponse successResponse,
        IOpenApiSchema? successResponseSchema,
        StreamFormat streamFormat)
    {
        if (streamFormat == StreamFormat.Binary)
        {
            return CreateResponseOverride(
                successResponse,
                CreateBinaryStreamType(operation),
                streamFormat);
        }

        var typeData = TryResolveTypeData(operation, schemaNode);
        if (!IsUsableTypeData(typeData))
        {
            typeData = null;
        }

        typeData ??= TryResolveTypeDataFromSuccessResponseSchema(operation, schemaNode, successResponse, successResponseSchema);
        if (typeData == null)
        {
            return null;
        }

        return CreateResponseOverride(successResponse, typeData.Value, streamFormat);
    }

    private static EndPointResponse? TryCreateComplementResponseOverride(
        OperationContext operation,
        IOpenApiSchema? successResponseSchema,
        EndPointResponse? knownResponse,
        StreamFormat streamFormat)
    {
        if (knownResponse == null || successResponseSchema == null)
        {
            return null;
        }

        var otherType = GetReferencedTypeData(successResponseSchema, operation.Settings.Namespace, operation)
            .FirstOrDefault(x => !TypeEquals(x, knownResponse.Value.Type));
        if (string.IsNullOrWhiteSpace(otherType.CSharpTypeWithoutNullability))
        {
            return null;
        }

        return CreateResponseOverride(
            successResponse: EndPointResponse.Default with
            {
                MimeType = string.Empty,
                ContentType = ContentType.String,
                Type = otherType,
            },
            typeData: otherType,
            streamFormat: streamFormat);
    }

    private static EndPointResponse CreateResponseOverride(
        EndPointResponse successResponse,
        TypeData typeData,
        StreamFormat streamFormat)
    {
        return successResponse with
        {
            MimeType = streamFormat switch
            {
                StreamFormat.ServerSentEvents => "text/event-stream",
                StreamFormat.Ndjson => "application/x-ndjson",
                StreamFormat.Binary => "application/octet-stream",
                _ => successResponse.MimeType,
            },
            ContentType = streamFormat switch
            {
                StreamFormat.Binary => ContentType.Stream,
                _ => successResponse.ContentType == ContentType.ByteArray
                    ? ContentType.String
                    : successResponse.ContentType,
            },
            Type = typeData,
        };
    }

    private static TypeData CreateBinaryStreamType(OperationContext operation)
    {
        return (TypeData.Default with
        {
            CSharpTypeRaw = "global::System.IO.Stream",
            Namespace = "System",
            GeneratedNamespace = operation.Settings.Namespace,
        }).WithCSharpComputedValues();
    }

    private static TypeData? TryResolveTypeData(OperationContext operation, JsonNode? schemaNode)
    {
        if (schemaNode is not JsonObject jsonObject)
        {
            return null;
        }

        var fernTypeName = TryGetStringValue(jsonObject["x-fern-type-name"]);
        if (!string.IsNullOrWhiteSpace(fernTypeName))
        {
            var byTypeName = FindTypeDataByShortName(operation, fernTypeName!.ToClassName());
            if (IsUsableTypeData(byTypeName))
            {
                return byTypeName;
            }

            return CreateGeneratedTypeData(fernTypeName!, operation.Settings);
        }

        if (TryGetReferenceId(jsonObject, out var referenceId))
        {
            var byReference = FindTypeDataByReferenceId(operation, referenceId);
            if (byReference != null)
            {
                return byReference;
            }
        }

        var compositeReferenceIds = GetCompositeReferenceIds(jsonObject);
        if (compositeReferenceIds.Count > 0)
        {
            var byComposite = FindTypeDataByCompositeReferenceIds(
                operation,
                compositeReferenceIds,
                fernTypeName);
            if (byComposite != null)
            {
                return byComposite;
            }
        }

        return null;
    }

    private static TypeData? TryResolveTypeDataFromSuccessResponseSchema(
        OperationContext operation,
        JsonNode? schemaNode,
        EndPointResponse successResponse,
        IOpenApiSchema? successResponseSchema)
    {
        if (schemaNode is not JsonObject jsonObject || successResponseSchema == null)
        {
            return null;
        }

        var fernTypeName = TryGetStringValue(jsonObject["x-fern-type-name"]);
        if (!string.IsNullOrWhiteSpace(fernTypeName))
        {
            var expectedTypeName = fernTypeName!.ToClassName();
            var resolvedType = GetReferencedTypeData(successResponseSchema, operation.Settings.Namespace, operation)
                .FirstOrDefault(x =>
                    string.Equals(x.ShortCSharpTypeWithoutNullability, expectedTypeName, StringComparison.Ordinal) ||
                    string.Equals(x.CSharpTypeWithoutNullability, $"global::{operation.Settings.Namespace}.{expectedTypeName}", StringComparison.Ordinal));
            if (IsUsableTypeData(resolvedType))
            {
                return resolvedType;
            }

            return CreateGeneratedTypeData(fernTypeName!, operation.Settings);
        }

        var successResponseSubTypes = successResponse.Type.SubTypes
            .Select(static x => x.Unbox<TypeData>())
            .Where(static x => !string.IsNullOrWhiteSpace(x.CSharpTypeWithoutNullability))
            .ToArray();

        var compositeReferenceIds = GetCompositeReferenceIds(jsonObject);
        if (compositeReferenceIds.Count > 0)
        {
            var compositeCandidates = successResponseSubTypes
                .Where(static x => x.AnyOfCount > 0 || x.OneOfCount > 0 || x.AllOfCount > 0)
                .ToArray();
            if (compositeCandidates.Length == 1)
            {
                return compositeCandidates[0];
            }
        }

        var propertyNames = GetPropertyNames(jsonObject["properties"]);
        if (propertyNames.Count > 0)
        {
            var directCandidates = successResponseSubTypes
                .Where(static x => x.Properties.Length > 0)
                .Select(x => new
                {
                    TypeData = x,
                    PropertyNames = new HashSet<string>(x.Properties, StringComparer.Ordinal),
                })
                .Where(x => x.PropertyNames.Count > 0)
                .ToArray();

            var exactPropertyMatch = directCandidates.FirstOrDefault(x =>
                x.PropertyNames.SetEquals(propertyNames));
            if (exactPropertyMatch != null)
            {
                return exactPropertyMatch.TypeData;
            }

            var supersetPropertyMatches = directCandidates
                .Where(x =>
                    x.PropertyNames.IsSupersetOf(propertyNames))
                .OrderBy(x => x.PropertyNames.Count)
                .ToArray();
            if (supersetPropertyMatches.Length == 1)
            {
                return supersetPropertyMatches[0].TypeData;
            }
        }

        return null;
    }

    private static TypeData? FindTypeDataByShortName(OperationContext operation, string shortTypeName)
    {
        return operation.Schemas
            .Select(x => x.ResolvedReference ?? x)
            .Where(static x => x.TypeData != TypeData.Default)
            .Select(static x => x.TypeData)
            .FirstOrDefault(x =>
                string.Equals(x.ShortCSharpTypeWithoutNullability, shortTypeName, StringComparison.Ordinal));
    }

    private static TypeData? FindTypeDataByReferenceId(OperationContext operation, string referenceId)
    {
        foreach (var schema in operation.Schemas)
        {
            var resolvedSchema = schema.ResolvedReference ?? schema;
            if (string.Equals(resolvedSchema.ComponentId, referenceId, StringComparison.Ordinal) ||
                string.Equals(resolvedSchema.ReferenceId, referenceId, StringComparison.Ordinal))
            {
                return resolvedSchema.TypeData;
            }
        }

        var className = referenceId.ToClassName();
        return FindTypeDataByShortName(operation, className);
    }

    private static IOpenApiSchema? GetSuccessResponseSchema(OperationContext operation, string? preferredMimeType)
    {
        var responses = (operation.Operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            .Where(static x => x.Key.StartsWith("2", StringComparison.OrdinalIgnoreCase))
            .ToArray();

        foreach (var response in responses)
        {
            var content = response.Value?.Content ?? new Dictionary<string, IOpenApiMediaType>();
            if (!string.IsNullOrWhiteSpace(preferredMimeType))
            {
                var preferred = content.FirstOrDefault(x => x.Key.IsMimeType(preferredMimeType!));
                if (preferred.Value?.Schema != null)
                {
                    return preferred.Value.Schema;
                }
            }

            var first = content.FirstOrDefault();
            if (first.Value?.Schema != null)
            {
                return first.Value.Schema;
            }
        }

        return null;
    }

    private static TypeData? FindTypeDataByCompositeReferenceIds(
        OperationContext operation,
        ISet<string> referenceIds,
        string? fernTypeName)
    {
        string? expectedTypeName = null;
        if (!string.IsNullOrWhiteSpace(fernTypeName))
        {
            expectedTypeName = fernTypeName!.ToClassName();
        }

        var candidates = operation.Schemas
            .Select(x => x.ResolvedReference ?? x)
            .Where(static x => x.TypeData != TypeData.Default)
            .Select(x => new
            {
                x.TypeData,
                ReferenceIds = GetCompositeReferenceIds(x.Schema),
            })
            .Where(x => x.ReferenceIds.Count > 0 && x.ReferenceIds.SetEquals(referenceIds))
            .ToArray();

        var preferredCandidate = candidates.FirstOrDefault(x =>
            expectedTypeName != null &&
            string.Equals(x.TypeData.ShortCSharpTypeWithoutNullability, expectedTypeName, StringComparison.Ordinal));
        if (preferredCandidate != null)
        {
            return preferredCandidate.TypeData;
        }

        return candidates.Select(static x => x.TypeData).FirstOrDefault();
    }

    private static TypeData[] GetReferencedTypeData(IOpenApiSchema schema, string generatedNamespace, OperationContext? operation)
    {
        var typeData = new List<TypeData>();

        AddReferencedTypeData(typeData, schema, generatedNamespace, operation);

        return typeData
            .Where(static x => !string.IsNullOrWhiteSpace(x.CSharpTypeWithoutNullability))
            .ToArray();
    }

    private static void AddReferencedTypeData(
        List<TypeData> typeData,
        IOpenApiSchema? schema,
        string generatedNamespace,
        OperationContext? operation)
    {
        if (schema == null)
        {
            return;
        }

        var referenceId = schema.GetReferenceId();
        if (!string.IsNullOrWhiteSpace(referenceId))
        {
            var referenceIdValue = referenceId!;
            var existingType = operation != null
                ? FindTypeDataByReferenceId(operation, referenceIdValue)
                : null;
            if (existingType is { } resolvedType &&
                IsUsableTypeData(resolvedType))
            {
                typeData.Add(resolvedType);
                return;
            }

            typeData.Add(CreateGeneratedTypeData(referenceIdValue, generatedNamespace, operation?.Settings.ToSchemaNamingSettings()));
            return;
        }

        foreach (var child in schema.OneOf ?? [])
        {
            AddReferencedTypeData(typeData, child, generatedNamespace, operation);
        }

        foreach (var child in schema.AnyOf ?? [])
        {
            AddReferencedTypeData(typeData, child, generatedNamespace, operation);
        }

        foreach (var child in schema.AllOf ?? [])
        {
            AddReferencedTypeData(typeData, child, generatedNamespace, operation);
        }
    }

    private static TypeData CreateGeneratedTypeData(string rawId, Settings settings)
    {
        return CreateGeneratedTypeData(rawId, settings.Namespace, settings.ToSchemaNamingSettings());
    }

    private static TypeData CreateGeneratedTypeData(
        string rawId,
        string rootNamespace,
        SchemaNamingSettings? schemaNamingSettings)
    {
        var className = rawId.ToClassName();
        var generatedNamespace = rootNamespace;

        if (schemaNamingSettings is { } namingSettings &&
            CSharpNamespacedTypeNameResolver.TryResolve(rawId, namingSettings, rootNamespace, out var resolved) &&
            resolved != null)
        {
            className = resolved.ClassName;
            generatedNamespace = resolved.GeneratedNamespace;
        }

        return (TypeData.Default with
        {
            CSharpTypeRaw = $"global::{generatedNamespace}.{className}",
            Namespace = generatedNamespace,
            GeneratedNamespace = generatedNamespace,
        }).WithCSharpComputedValues();
    }

    private static bool IsUsableTypeData(TypeData? typeData)
    {
        return typeData is { } value &&
               !string.IsNullOrWhiteSpace(value.CSharpTypeWithoutNullability) &&
               !value.CSharpTypeWithoutNullability.Contains("global::.", StringComparison.Ordinal);
    }

    private static HashSet<string> GetCompositeReferenceIds(IOpenApiSchema schema)
    {
        var referenceIds = new HashSet<string>(StringComparer.Ordinal);

        AddReferenceIds(referenceIds, schema.OneOf);
        AddReferenceIds(referenceIds, schema.AnyOf);
        AddReferenceIds(referenceIds, schema.AllOf);

        return referenceIds;
    }

    private static HashSet<string> GetCompositeReferenceIds(JsonObject jsonObject)
    {
        var referenceIds = new HashSet<string>(StringComparer.Ordinal);

        foreach (var referenceId in GetReferenceIds(jsonObject["oneOf"]))
        {
            referenceIds.Add(referenceId);
        }

        foreach (var referenceId in GetReferenceIds(jsonObject["anyOf"]))
        {
            referenceIds.Add(referenceId);
        }

        foreach (var referenceId in GetReferenceIds(jsonObject["allOf"]))
        {
            referenceIds.Add(referenceId);
        }

        return referenceIds;
    }

    private static HashSet<string> GetPropertyNames(IOpenApiSchema schema)
    {
        return new HashSet<string>((schema.Properties ?? new Dictionary<string, IOpenApiSchema>()).Keys, StringComparer.Ordinal);
    }

    private static HashSet<string> GetPropertyNames(JsonNode? node)
    {
        return node is JsonObject jsonObject
            ? new HashSet<string>(jsonObject.Select(static x => x.Key), StringComparer.Ordinal)
            : new HashSet<string>(StringComparer.Ordinal);
    }

    private static void AddReferenceIds(HashSet<string> referenceIds, IEnumerable<IOpenApiSchema>? schemas)
    {
        foreach (var referenceId in (schemas ?? []).Select(static x => x.GetReferenceId()))
        {
            if (!string.IsNullOrWhiteSpace(referenceId))
            {
                referenceIds.Add(referenceId!);
            }
        }
    }

    private static IEnumerable<string> GetReferenceIds(JsonNode? node)
    {
        if (node is not JsonArray jsonArray)
        {
            yield break;
        }

        foreach (var item in jsonArray.OfType<JsonObject>())
        {
            if (TryGetReferenceId(item, out var referenceId))
            {
                yield return referenceId;
            }
        }
    }

    private static bool TryGetReferenceId(JsonObject jsonObject, out string referenceId)
    {
        referenceId = string.Empty;
        var referencePath = TryGetStringValue(jsonObject["$ref"]);
        if (string.IsNullOrWhiteSpace(referencePath))
        {
            return false;
        }

        var referencePathValue = referencePath!;
        var lastSlash = referencePathValue.LastIndexOf('/');
        referenceId = lastSlash >= 0
            ? referencePathValue.Substring(lastSlash + 1)
            : referencePathValue;
        return !string.IsNullOrWhiteSpace(referenceId);
    }

    private static string? TryGetStringValue(JsonNode? node)
    {
        return node is JsonValue jsonValue &&
               jsonValue.TryGetValue<string>(out var value)
            ? value
            : null;
    }

    private static bool TypeEquals(TypeData left, TypeData right)
    {
        return string.Equals(
                   left.CSharpTypeWithoutNullability,
                   right.CSharpTypeWithoutNullability,
                   StringComparison.Ordinal) ||
               string.Equals(
                   left.ShortCSharpTypeWithoutNullability,
                   right.ShortCSharpTypeWithoutNullability,
                   StringComparison.Ordinal);
    }
}
