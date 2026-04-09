using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static class CSharpEndPointResponseFactory
{
    public static EndPointResponse FromResponse(
        KeyValuePair<string, IOpenApiResponse> responseWithStatusCode,
        OperationContext operation,
        string? preferredMimeType = null)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var responses = responseWithStatusCode.Value?.Content?
            .Select(x => (
                StatusCode: responseWithStatusCode.Key,
                Response: responseWithStatusCode.Value,
                MimeType: x.Key,
                MediaType: x.Value))
            .ToArray() ?? [];
        if (responses.Length == 0)
        {
            return EndPointResponse.Default with
            {
                StatusCode = responseWithStatusCode.Key,
            };
        }

        if (preferredMimeType != null)
        {
            var filtered = responses.Where(x => x.MimeType.IsMimeType(preferredMimeType)).ToArray();
            if (filtered.Length > 0)
            {
                responses = filtered;
            }
        }

        var response = responses.First();
        var usesItemSchemaForStream =
            response.MediaType.ItemSchema != null &&
            (response.MimeType.IsSequentialJsonMimeType() || response.MimeType.IsServerSentEventsMimeType());
        var responseContext = operation.Schemas.FirstOrDefault(x =>
                x.Hint == Hint.Response &&
                x.ResponseStatusCode == response.StatusCode &&
                (x.ContentType == null || x.ContentType == response.MimeType) &&
                x.IsMediaTypeItemSchema == usesItemSchemaForStream) ??
            operation.Schemas.FirstOrDefault(x =>
                x.Hint == Hint.Response &&
                x.ResponseStatusCode == response.StatusCode &&
                (x.ContentType == null || x.ContentType == response.MimeType));
        var isBinaryResponse = response.MimeType.IsBinaryResponseMimeType() ||
                               responseContext?.TypeData.CSharpTypeWithoutNullability == "byte[]" ||
                               responseContext?.TypeData.IsBinary == true;
        var contentType = isBinaryResponse
            ? ContentType.ByteArray
            : ContentType.String;
        TypeData? responseType = contentType switch
        {
            ContentType.ByteArray => (TypeData.Default with
            {
                CSharpTypeRaw = "byte[]",
                IsBinary = true,
                GeneratedNamespace = operation.Settings.Namespace,
            }).WithCSharpComputedValues(),
            _ => responseContext?.TypeData,
        };
        if ((response.MimeType.IsSequentialJsonMimeType() || response.MimeType.IsServerSentEventsMimeType()) &&
            responseType is { IsArray: true, SubTypes.Length: > 0 })
        {
            responseType = responseType.Value.SubTypes[0].Unbox<TypeData>();
        }

        if (responseType?.CSharpTypeWithoutNullability == "object")
        {
            contentType = ContentType.String;
            responseType = (TypeData.Default with
            {
                CSharpTypeRaw = "string",
                IsNullable = true,
                GeneratedNamespace = operation.Settings.Namespace,
            }).WithCSharpComputedValues();
        }

        return new EndPointResponse(
            StatusCode: responseWithStatusCode.Key,
            Description: response.Response.Description ?? string.Empty,
            MimeType: response.MimeType,
            ContentType: contentType,
            Type: responseType ?? TypeData.Default,
            HasHeaders: response.Response.Headers?.Count > 0);
    }
}
