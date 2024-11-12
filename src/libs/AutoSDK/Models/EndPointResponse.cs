using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;

namespace AutoSDK.Models;

public readonly record struct EndPointResponse(
    bool IsSuccess,
    bool IsDefault,
    string StatusCode,
    string MimeType,
    ContentType ContentType,
    TypeData Type
)
{
    public static EndPointResponse Default => new(
        IsSuccess: true,
        IsDefault: false,
        StatusCode: "200",
        MimeType: string.Empty,
        ContentType: ContentType.String,
        Type: TypeData.Default);
    
    public static EndPointResponse FromResponse(KeyValuePair<string, OpenApiResponse> responseWithStatusCode, OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));
        
        var responses = responseWithStatusCode.Value?.ResolveIfRequired().Content?
            .Select(x => (
                StatusCode: responseWithStatusCode.Key,
                Response: responseWithStatusCode.Value,
                MimeType: x.Key,
                MediaType: x.Value))
            .ToArray() ?? [];
        if (responses.Length == 0)
        {
            return Default with
            {
                IsSuccess = responseWithStatusCode.Key.StartsWith("2", StringComparison.OrdinalIgnoreCase),
                StatusCode = responseWithStatusCode.Key,
            };
        }
        
        var response = responses.First();
        
        var contentType = response.MimeType.Contains("application/octet-stream")
            ? ContentType.ByteArray
            : ContentType.String;
        var responseContext = operation.Schemas.FirstOrDefault(x => x.Hint == Hint.Response && x.ResponseStatusCode == response.StatusCode);
        TypeData? responseType = contentType switch
        {
            ContentType.ByteArray => TypeData.Default with
            {
                CSharpTypeRaw = "byte[]",
            },
            _ => responseContext?.TypeData,
        };
        if (responseType?.CSharpTypeWithoutNullability == "object")
        {
            contentType = ContentType.String;
            responseType = TypeData.Default with
            {
                CSharpTypeRaw = "string",
                IsNullable = true,
            };
        }

        var endPoint = new EndPointResponse(
            IsSuccess: responseWithStatusCode.Key.StartsWith("2", StringComparison.OrdinalIgnoreCase),
            IsDefault: responseWithStatusCode.Key == "default",
            StatusCode: responseWithStatusCode.Key,
            MimeType: response.MimeType,
            ContentType: contentType,
            Type: responseType ?? TypeData.Default);
        
        return endPoint;
    }
}