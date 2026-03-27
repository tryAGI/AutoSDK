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
        bool? forcedRequestStreamValue = null)
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

        var duplicateParameters = parameters
            .GroupBy(x => x.Name)
            .Where(x => x.Count() > 1)
            .Select(x => x.Key)
            .ToArray();
        foreach (var duplicateParameter in duplicateParameters)
        {
            var index = 1;
            for (var i = 0; i < parameters.Count; i++)
            {
                if (parameters[i].Name == duplicateParameter)
                {
                    parameters[i] = parameters[i] with
                    {
                        Name = $"{parameters[i].Name}{index++}",
                    };
                }
            }
        }

        var preparedPath = operation.OperationPath.PreparePath(parameters);
        var queryParameters = ParameterSerializer.SerializeQueryParameters(parameters);

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

        foreach (var requestProperty in requestContext?.ResolvedReference?.ClassData?.Properties ??
                                        requestContext?.ClassData?.Properties ??
                                        [])
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

        if (streamFormat == StreamFormat.None &&
            HasBooleanFernStreamingExtension(operation.Operation))
        {
            var isJsonStream =
                successResponse.MimeType.Contains("application/json", StringComparison.OrdinalIgnoreCase) ||
                successResponse.MimeType.Contains("+json", StringComparison.OrdinalIgnoreCase);

            if (isJsonStream)
            {
                streamFormat = StreamFormat.Ndjson;
            }
            else
            {
                streamFormat = StreamFormat.Binary;
                successResponse = successResponse with
                {
                    ContentType = ContentType.Stream,
                    Type = (TypeData.Default with
                    {
                        CSharpTypeRaw = "global::System.IO.Stream",
                        Namespace = "System",
                        GeneratedNamespace = operation.Settings.Namespace,
                    }).WithCSharpComputedValues(),
                };
            }
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
            Remarks: GetCodeSamplesRemarks(operation.Operation));
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

        JsonObject? bestSample = null;
        foreach (var item in samplesArray)
        {
            if (item is not JsonObject sample)
            {
                continue;
            }

            var lang = string.Empty;
            if (sample.TryGetPropertyValue("lang", out var langNode) &&
                langNode is JsonValue langValue &&
                langValue.TryGetValue<string>(out var langStr))
            {
                lang = langStr;
            }

            if (string.Equals(lang, "csharp", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(lang, "c#", StringComparison.OrdinalIgnoreCase))
            {
                bestSample = sample;
                break;
            }

            if (bestSample == null ||
                string.Equals(lang, "curl", StringComparison.OrdinalIgnoreCase))
            {
                bestSample = sample;
            }
        }

        if (bestSample == null)
        {
            return string.Empty;
        }

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

    private static bool HasBooleanFernStreamingExtension(OpenApiOperation operation)
    {
        if (!(operation.Extensions ?? new Dictionary<string, IOpenApiExtension>())
            .TryGetValue("x-fern-streaming", out var extension))
        {
            return false;
        }

        var jsonNode = OpenApiExtensions.TryGetExtensionJsonNode(extension);
        if (jsonNode is JsonValue jsonValue &&
            jsonValue.TryGetValue<bool>(out var isStreaming))
        {
            return isStreaming;
        }

        return bool.TryParse(jsonNode?.ToString() ?? extension.ToString(), out var parsed) && parsed;
    }
}
