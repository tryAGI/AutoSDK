using System.Collections.Immutable;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Naming.Clients;
using AutoSDK.Serialization.Form;
using Microsoft.OpenApi;

#pragma warning disable CA1308

namespace AutoSDK.Models;

public record struct EndPoint(
    string Id,
    string ClassName,
    Tag Tag,
    string BaseUrl,
    StreamFormat StreamFormat,
    string Path,
    string RequestMediaType,
    EquatableArray<MethodParameter> Parameters,
    EndPointResponse SuccessResponse,
    EquatableArray<EndPointResponse> ErrorResponses,
    EquatableArray<Authorization> Authorizations,
    EquatableArray<MethodParameter> QueryParameters,
    System.Net.Http.HttpMethod HttpMethod,
    ContentType ContentType,
    string Summary,
    string Description,
    string BaseUrlSummary,
    string CliAction,
    Settings Settings,
    Settings GlobalSettings,
    bool IsDeprecated,
    string ExperimentalStage,
    TypeData RequestType,
    bool? ForcedRequestStreamValue
)
{
    public bool Stream => StreamFormat != StreamFormat.None;
    public bool RawStream => StreamFormat == StreamFormat.Binary;
    public bool EnumerableStream => Stream && !RawStream;
    public string MethodName => $"{NotAsyncMethodName}Async";
    public string NotAsyncMethodName => Id.ToPropertyName();
    public bool IsMultipartFormData => RequestMediaType == "multipart/form-data";
    
    public string FileNameWithoutExtension => $"{Settings.Namespace}.{ClassName}.{Id.ToPropertyName()}";
    
    public string InterfaceFileNameWithoutExtension => $"{Settings.Namespace}.I{ClassName}.{Id.ToPropertyName()}";
    
    public static EndPoint FromSchema(
        OperationContext operation,
        string? preferredMimeType = null,
        string? methodNameSuffix = null,
        bool? forcedRequestStreamValue = null)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        
        var authorizations = (operation.Operation.Security ?? [])
            .SelectMany(x => x)
            .Select(x => Authorization.FromOpenApiSecurityScheme(x.Key, operation.Settings, operation.GlobalSettings))
            .ToImmutableArray();
        if (authorizations.Length == 0)
        {
            authorizations = operation.GlobalSecurityRequirements
                .SelectMany(x => x)
                .Select(x => Authorization.FromOpenApiSecurityScheme(x.Key, operation.Settings, operation.GlobalSettings))
                .ToImmutableArray();
        }
        
        var parameters = operation.Schemas
            .Where(x => x is { Hint: Hint.Parameter, ParameterData: not null })
            .Select(x => x.ParameterData!.Value)
            .ToList();
        
        // Ensure that parameters with the same name are unique
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
            // Old Code for Microsoft.OpenApi 1.x
            //operation.Operation.RequestBody?.ResolveIfRequired().Content ??
            operation.Operation.RequestBody?.Content ??
            new Dictionary<string, IOpenApiMediaType>();

        var requestContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Request);
        TypeData? requestType = requestContext?.TypeData;
        var requestMediaType = requestMediaTypes
            .Select(x => x.Key)
            .FirstOrDefault() ?? "application/json";

        // If media type is octet-stream but no schema was found, treat as byte[]
        if (requestType == null && requestMediaType == "application/octet-stream")
        {
            requestType = TypeData.Default with
            {
                CSharpTypeRaw = "byte[]",
                IsBinary = true,
            };
        }

        if (requestType?.IsBase64 == true)
        {
            requestMediaType = "application/octet-stream";
        }

        var responses = (operation.Operation.Responses ?? new Dictionary<string, IOpenApiResponse>())
            .Select(x => EndPointResponse.FromResponse(x, operation, preferredMimeType: preferredMimeType))
            .ToArray();

        foreach (var requestProperty in requestContext?.ResolvedReference?.ClassData?.Properties ??
                                        requestContext?.ClassData?.Properties ??
                                        [])
        {
            if (requestProperty.IsReadOnly)
            {
                continue;
            }
            
            parameters.Add(MethodParameter.Default with
            {
                Id = requestProperty.Id,
                Name = parameters.All(x => x.Name != requestProperty.Name)
                    ? requestProperty.Name
                    : $"request{requestProperty.Name.ToPropertyName()}",
                Type = requestProperty.Type with
                {
                    CSharpTypeNullability =
                        requestProperty.Type.IsNullable ||
                        (requestProperty.Type.CSharpTypeNullability && !requestProperty.IsRequired && !requestProperty.IsWriteOnly),
                },
                IsRequired = requestProperty.IsRequired || requestProperty.IsWriteOnly,
                IsMultiPartFormDataFilename = requestProperty.IsMultiPartFormDataFilename,
                DefaultValue = requestProperty.DefaultValue,
                IsDeprecated = requestProperty.IsDeprecated,
                Settings = requestProperty.Settings,
                Summary = requestProperty.Summary,
                ConverterType = requestProperty.ConverterType,
                Description = requestProperty.Description,
            });
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
                    Type = TypeData.Default with
                    {
                        CSharpTypeRaw = "global::System.IO.Stream",
                        Namespace = "System",
                        Settings = operation.Settings,
                    },
                };
            }
        }
        var endPoint = new EndPoint(
            Id: string.IsNullOrWhiteSpace(methodNameSuffix)
                ? operation.MethodName
                : operation.MethodName + methodNameSuffix,
            ClassName: operation.Settings.GroupByTags && operation.Tag != Tag.Empty
                ? ClientNameGenerator.Generate(operation.Tag)
                : operation.Settings.ClassName.Replace(".", string.Empty),
            Tag: operation.Tag,
            BaseUrl: string.Empty,
            StreamFormat: streamFormat,
            Path: preparedPath,
            RequestMediaType: requestMediaType,
            Parameters: parameters.ToImmutableArray(),
            SuccessResponse: successResponse,
            ErrorResponses: responses.Where(x => !x.Is2XX).ToImmutableArray(),
            QueryParameters: queryParameters.ToImmutableArray(),
            Authorizations: authorizations,
            HttpMethod: operation.OperationType,
            ContentType: successResponse.ContentType,
            Summary: operation.Operation.GetXmlDocumentationSummary(),
            Description: operation.Operation.Description ?? string.Empty,
            BaseUrlSummary: string.Empty,
            CliAction:
                ((operation.Operation.Extensions ?? new Dictionary<string, IOpenApiExtension>())
                    .FirstOrDefault(x => x.Key == "x-cli-action")
                    .Value is JsonValue cliActionValue && cliActionValue.TryGetValue<string>(out var cliActionStr)
                    ? cliActionStr
                    : null) ??
                operation.MethodName.FirstWord().ToLowerInvariant(),
            Settings: operation.Settings,
            GlobalSettings: operation.GlobalSettings,
            IsDeprecated: operation.Operation.IsDeprecated(),
            ExperimentalStage: operation.Operation.GetExperimentalStage(),
            RequestType: requestType ?? TypeData.Default,
            ForcedRequestStreamValue: forcedRequestStreamValue);

        return endPoint;
    }

    private static bool HasBooleanFernStreamingExtension(OpenApiOperation operation)
    {
        if (!(operation.Extensions ?? new Dictionary<string, IOpenApiExtension>())
            .TryGetValue("x-fern-streaming", out var extension))
        {
            return false;
        }

        var extensionType = extension.GetType();
        var jsonNode = extension as JsonNode ??
                       extensionType
                           .GetProperty(
                               "Node",
                               System.Reflection.BindingFlags.Instance |
                               System.Reflection.BindingFlags.Public |
                               System.Reflection.BindingFlags.NonPublic)?
                           .GetValue(extension) as JsonNode ??
                       extensionType
                           .GetField(
                               "jsonNode",
                               System.Reflection.BindingFlags.Instance |
                               System.Reflection.BindingFlags.Public |
                               System.Reflection.BindingFlags.NonPublic)?
                           .GetValue(extension) as JsonNode;
        if (jsonNode is JsonValue jsonValue &&
            jsonValue.TryGetValue<bool>(out var isStreaming))
        {
            return isStreaming;
        }

        return bool.TryParse(jsonNode?.ToString() ?? extension.ToString(), out var parsed) && parsed;
    }
}
