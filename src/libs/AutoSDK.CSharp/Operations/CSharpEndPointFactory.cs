using System.Collections.Immutable;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Naming.Clients;
using AutoSDK.Naming.Parameters;
using AutoSDK.Serialization.Form;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

#pragma warning disable CA1308

namespace AutoSDK.Generation;

public static class CSharpEndPointFactory
{
    public static EndPoint CreateEndPoint(
        OperationContext operation,
        string? preferredMimeType = null,
        string? methodNameSuffix = null,
        bool? forcedRequestStreamValue = null,
        EndPointResponse? successResponseOverride = null,
        StreamFormat? streamFormatOverride = null,
        string? streamTerminator = null)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var authorizations = (operation.Operation.Security ?? [])
            .SelectMany(x => x)
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(x.Key, operation.Settings, operation.GlobalSettings))
            .ToImmutableArray();
        if (authorizations.Length == 0)
        {
            authorizations = operation.GlobalSecurityRequirements
                .SelectMany(x => x)
                .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(x.Key, operation.Settings, operation.GlobalSettings))
                .ToImmutableArray();
        }

        var parameters = operation.Schemas
            .Where(x => x is { Hint: Hint.Parameter, ParameterData: not null })
            .Select(x => x.ParameterData!.Value)
            .ToList();

        var requestMediaTypes =
            operation.Operation.RequestBody?.Content ??
            new Dictionary<string, IOpenApiMediaType>();

        var requestContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Request);
        TypeData? requestType = requestContext?.TypeData;
        var requestMediaType = requestMediaTypes
            .Select(x => x.Key)
            .FirstOrDefault() ?? "application/json";

        if (requestType == null && requestMediaType == "application/octet-stream")
        {
            requestType = (TypeData.Default with
            {
                CSharpTypeRaw = "byte[]",
                IsBinary = true,
                GeneratedNamespace = operation.Settings.Namespace,
            }).WithCSharpComputedValues();
        }

        if (requestType?.IsBase64 == true)
        {
            requestMediaType = "application/octet-stream";
        }

        var responses = (operation.Operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            .Select(x => CSharpEndPointResponseFactory.FromResponse(x, operation, preferredMimeType: preferredMimeType))
            .ToArray();

        foreach (var requestProperty in GetRequestProperties(requestContext))
        {
            if (requestProperty.IsReadOnly)
            {
                continue;
            }

            parameters.Add((MethodParameter.Default with
            {
                Id = requestProperty.Id,
                Name = parameters.All(x => x.Name != requestProperty.Name)
                    ? requestProperty.Name
                    : $"request{requestProperty.Name.ToPropertyName()}",
                Type = (requestProperty.Type with
                {
                    CSharpTypeNullability =
                        requestProperty.Type.IsNullable ||
                        (requestProperty.Type.CSharpTypeNullability && !requestProperty.IsRequired && !requestProperty.IsWriteOnly),
                }).WithCSharpComputedValues(),
                IsRequired = requestProperty.IsRequired || requestProperty.IsWriteOnly,
                IsMultiPartFormDataFilename = requestProperty.IsMultiPartFormDataFilename,
                DefaultValue = requestProperty.DefaultValue,
                IsDeprecated = requestProperty.IsDeprecated,
                Settings = requestProperty.Settings,
                Summary = requestProperty.Summary,
                ConverterType = requestProperty.ConverterType,
                Description = requestProperty.Description,
            }).WithCSharpParameterNames().WithCSharpComputedValues());
        }

        DeduplicateMethodParameterNames(parameters);

        var preparedPath = operation.OperationPath.PreparePath(parameters);
        var queryParameters = ParameterSerializer.SerializeQueryParameters(parameters);

        var successResponse = responses.Any(x => x.Is2XX && !string.IsNullOrWhiteSpace(x.Type.CSharpTypeRaw))
            ? responses.First(x => x.Is2XX && !string.IsNullOrWhiteSpace(x.Type.CSharpTypeRaw))
            : responses.Any(x => x.Is2XX)
                ? responses.First(x => x.Is2XX)
                : responses.Any(x => x.IsDefault)
                    ? responses.First(x => x.IsDefault)
                    : EndPointResponse.Default;
        var streamFormat = preferredMimeType == "text/event-stream"
            ? StreamFormat.ServerSentEvents
            : responses.Any(x => x.MimeType.Contains("application/x-ndjson"))
                ? StreamFormat.Ndjson
                : responses.Any(x => x.MimeType.Contains("text/event-stream"))
                    ? StreamFormat.ServerSentEvents
                    : StreamFormat.None;
        if (successResponseOverride is EndPointResponse responseOverride)
        {
            successResponse = responseOverride;
        }

        if (streamFormatOverride is StreamFormat streamFormatValue)
        {
            streamFormat = streamFormatValue;
        }

        var endPointId = string.IsNullOrWhiteSpace(methodNameSuffix)
            ? operation.MethodName
            : operation.MethodName + methodNameSuffix;
        var className = operation.Settings.GroupByTags && operation.Tag != Tag.Empty
            ? CSharpClientNameGenerator.Generate(operation.Tag)
            : operation.Settings.ClassName.Replace(".", string.Empty);
        var notAsyncMethodName = endPointId.ToPropertyName();

        return new EndPoint(
            Id: endPointId,
            ClassName: className,
            NotAsyncMethodName: notAsyncMethodName,
            MethodName: $"{notAsyncMethodName}Async",
            CliCommandClassName: operation.Tag != Tag.Empty && !string.IsNullOrWhiteSpace(operation.Tag.SafeName)
                ? $"{operation.Tag.SafeName}{notAsyncMethodName}Command"
                : $"{notAsyncMethodName}Command",
            FileNameWithoutExtension: $"{operation.Settings.Namespace}.{className}.{notAsyncMethodName}",
            InterfaceFileNameWithoutExtension: $"{operation.Settings.Namespace}.I{className}.{notAsyncMethodName}",
            Tag: operation.Tag,
            BaseUrl: string.Empty,
            StreamFormat: streamFormat,
            Path: preparedPath,
            RequestMediaType: requestMediaType,
            Parameters: parameters.ToImmutableArray(),
            SuccessResponse: successResponse,
            ErrorResponses: responses.Where(x => !x.Is2XX).ToImmutableArray(),
            Authorizations: authorizations,
            QueryParameters: queryParameters.ToImmutableArray(),
            HttpMethod: operation.OperationType,
            ContentType: successResponse.ContentType,
            Summary: operation.Operation.GetXmlDocumentationSummary(),
            Description: operation.Operation.Description ?? string.Empty,
            BaseUrlSummary: string.Empty,
            CliAction:
                (OpenApiExtensions.TryGetExtensionStringValue(
                    operation.Operation.Extensions, "x-cli-action", out var cliActionStr)
                    ? cliActionStr
                    : null) ??
                operation.MethodName.FirstWord().ToLowerInvariant(),
            Settings: operation.Settings,
            GlobalSettings: operation.GlobalSettings,
            IsDeprecated: operation.Operation.IsDeprecated(),
            DeprecationMessage: operation.Operation.GetDeprecationMessage(),
            ExperimentalStage: operation.Operation.GetExperimentalStage(),
            RequestType: requestType ?? TypeData.Default,
            ForcedRequestStreamValue: forcedRequestStreamValue,
            StreamTerminator: streamFormat == StreamFormat.ServerSentEvents
                ? streamTerminator ?? "[DONE]"
                : string.Empty,
            Remarks: GetCodeSamplesRemarks(operation.Operation));
    }

    private static void DeduplicateMethodParameterNames(List<MethodParameter> parameters)
    {
        var usedParameterNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var suffixes = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        for (var i = 0; i < parameters.Count; i++)
        {
            var parameter = parameters[i];
            if (usedParameterNames.Add(parameter.ParameterName))
            {
                continue;
            }

            suffixes.TryGetValue(parameter.Name, out var suffix);
            suffix = Math.Max(suffix, 1);

            MethodParameter updated;
            do
            {
                suffix++;
                updated = (parameter with
                {
                    Name = $"{parameter.Name}{suffix}",
                }).WithCSharpParameterNames().WithCSharpComputedValues();
            }
            while (!usedParameterNames.Add(updated.ParameterName));

            suffixes[parameter.Name] = suffix;
            parameters[i] = updated;
        }
    }

    private static ImmutableArray<PropertyData> GetRequestProperties(SchemaContext? requestContext)
    {
        if (requestContext == null)
        {
            return [];
        }

        var sourceContext = requestContext.ResolvedReference ?? requestContext;
        if (sourceContext.ClassData?.Properties is { Length: > 0 } properties)
        {
            return properties;
        }

        var directProperties = GetDirectRequestProperties(sourceContext);
        if (directProperties.Length > 0)
        {
            return directProperties;
        }

        var current = sourceContext;
        while (current.IsAllOf)
        {
            var source = GetPropertySource(current);
            if (source == null || source.Count != 1 || source[0].IsProperty)
            {
                return [];
            }

            current = source[0].ResolvedReference ?? source[0];
            if (current.ClassData?.Properties is { Length: > 0 } unwrappedProperties)
            {
                return unwrappedProperties;
            }

            directProperties = GetDirectRequestProperties(current);
            if (directProperties.Length > 0)
            {
                return directProperties;
            }
        }

        return [];
    }

    private static ImmutableArray<PropertyData> GetDirectRequestProperties(SchemaContext context)
    {
        var source = GetPropertySource(context);
        if (source == null || source.Count == 0)
        {
            return [];
        }

        var discriminatorPropertyName = context.IsBaseClass
            ? context.Schema.Discriminator?.PropertyName
            : null;
        var hasDiscriminator = !string.IsNullOrWhiteSpace(discriminatorPropertyName);

        var builder = ImmutableArray.CreateBuilder<PropertyData>(source.Count);
        var seenNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        for (var i = 0; i < source.Count; i++)
        {
            var child = source[i];
            if (child is not { IsProperty: true, PropertyData: not null })
            {
                continue;
            }

            foreach (var property in child.ComputedProperties)
            {
                if ((!hasDiscriminator || property.Id != discriminatorPropertyName) &&
                    seenNames.Add(property.Name))
                {
                    builder.Add(property);
                }
            }
        }

        return builder.ToImmutable();
    }

    private static IList<SchemaContext>? GetPropertySource(SchemaContext context)
    {
        return context.IsDerivedClass
            ? context.DerivedClassContext.Children
            : !context.Schema.IsEnum()
                ? context.Children
                : null;
    }

    private static string GetCodeSamplesRemarks(OpenApiOperation operation)
    {
        if (!(operation.Extensions ?? new Dictionary<string, IOpenApiExtension>())
            .TryGetValue("x-codeSamples", out var extension))
        {
            return string.Empty;
        }

        var jsonNode = OpenApiExtensions.TryGetExtensionJsonNode(extension);
        if (jsonNode is not JsonArray samplesArray || samplesArray.Count == 0)
        {
            return string.Empty;
        }

        var objectSamples = samplesArray.OfType<JsonObject>().ToArray();
        if (objectSamples.Length == 0)
        {
            return string.Empty;
        }

        JsonObject bestSample =
            objectSamples.FirstOrDefault(static sample => HasSampleLang(sample, "csharp") || HasSampleLang(sample, "c#")) ??
            objectSamples.FirstOrDefault(static sample => HasSampleLang(sample, "curl")) ??
            objectSamples[0];

        var source = string.Empty;
        if (bestSample.TryGetPropertyValue("source", out var sourceNode) &&
            sourceNode is JsonValue sourceValue &&
            sourceValue.TryGetValue<string>(out var sourceStr))
        {
            source = sourceStr;
        }

        if (string.IsNullOrWhiteSpace(source))
        {
            return string.Empty;
        }

        return source.ClearForXml();
    }

    private static bool HasSampleLang(JsonObject sample, string expectedLang)
    {
        if (sample.TryGetPropertyValue("lang", out var langNode) &&
            langNode is JsonValue langValue &&
            langValue.TryGetValue<string>(out var langStr))
        {
            return string.Equals(langStr, expectedLang, StringComparison.OrdinalIgnoreCase);
        }

        return false;
    }
}
