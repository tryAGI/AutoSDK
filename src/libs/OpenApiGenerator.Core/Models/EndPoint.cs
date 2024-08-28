using System.Collections.Immutable;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Naming.Clients;

namespace OpenApiGenerator.Core.Models;

public readonly record struct EndPoint(
    string Id,
    string Namespace,
    string ClassName,
    string BaseUrl,
    bool Stream,
    string Path,
    string RequestMediaType,
    ImmutableArray<PropertyData> Properties,
    OperationType HttpMethod,
    ContentType ContentType,
    string Summary,
    string BaseUrlSummary,
    Settings Settings,
    bool IsDeprecated,
    TypeData RequestType,
    TypeData ResponseType,
    ImmutableArray<string> Converters
)
{
    public string MethodName => $"{NotAsyncMethodName}Async";
    public string NotAsyncMethodName => Id.ToPropertyName();
    public bool IsMultipartFormData => RequestMediaType == "multipart/form-data";
    
    public string FileNameWithoutExtension => string.IsNullOrWhiteSpace(Path)
        ? $"{Namespace}.{ClassName}"
        : $"{Namespace}.{ClassName}.{Id.ToPropertyName()}";
    
    public static EndPoint FromSchema(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        
        var parameters = operation.Schemas
            .Where(x => x is { Hint: Hint.Parameter, PropertyData: not null })
            .Select(x => x.PropertyData!.Value)
            .ToArray();
        
        // Ensure that parameters with the same name are unique
        var duplicateParameters = parameters
            .GroupBy(x => x.Name)
            .Where(x => x.Count() > 1)
            .Select(x => x.Key)
            .ToArray();
        foreach (var duplicateParameter in duplicateParameters)
        {
            var index = 1;
            for (var i = 0; i < parameters.Length; i++)
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
 
        var requestMediaTypes =
            operation.Operation.RequestBody?.ResolveIfRequired().Content ??
            new Dictionary<string, OpenApiMediaType>();

        var requestContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Request);
        TypeData? requestType = requestContext?.TypeData;
        var requestMediaType = requestMediaTypes
            .Select(x => x.Key)
            .FirstOrDefault() ?? "application/json";
        if (requestType?.IsBase64 == true)
        {
            requestMediaType = "application/octet-stream";
        }
        
        var responses = (operation.Operation.Responses ?? [])
            .SelectMany(x => x.Value?.ResolveIfRequired().Content?.Select(y => (Response: x, MediaType: y)) ?? [])
            .ToArray();
        var responseContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Response);
        TypeData? responseType = responseContext?.TypeData;

        var properties = parameters.ToList();
        foreach (var requestProperty in requestContext?.ResolvedReference?.ClassData?.Properties ??
                                        requestContext?.ClassData?.Properties ??
                                        [])
        {
            if (properties.All(x => x.Name != requestProperty.Name))
            {
                properties.Add(requestProperty);
            }
            else
            {
                properties.Add(requestProperty with
                {
                    Name = $"request{requestProperty.Name.ToPropertyName()}",
                });
            }
        }
        
        var firstTag = (operation.Operation.Tags ?? []).FirstOrDefault();
        var endPoint = new EndPoint(
            Id: operation.MethodName,
            Namespace: operation.Settings.Namespace,
            ClassName: operation.Settings.GroupByTags && firstTag != null
                ? ClientNameGenerator.Generate(operation.Settings, firstTag)
                : operation.Settings.ClassName.Replace(".", string.Empty),
            BaseUrl: string.Empty,
            Stream: responses
                .Any(x => x.MediaType.Key.Contains("application/x-ndjson")),
            Path: preparedPath,
            RequestMediaType: requestMediaType,
            Properties: properties.ToImmutableArray(),
            HttpMethod: operation.OperationType,
            ContentType: responses
                .Any(x => x.MediaType.Key.Contains("application/octet-stream"))
                ? ContentType.ByteArray
                : ContentType.String,
            Summary: operation.Operation.GetXmlDocumentationSummary(),
            BaseUrlSummary: string.Empty,
            Settings: operation.Settings,
            IsDeprecated: operation.Operation.Deprecated,
            RequestType: requestType ?? TypeData.Default,
            ResponseType: responseType ?? TypeData.Default,
            Converters: []);
        
        return endPoint;
    }
}