using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static EndPointResponse[][] GetSuccessVariants(EndPoint endPoint) => endPoint.SuccessResponses
        .GroupBy(static response => (response.StatusCode, response.ContentType, response.Type.CSharpType))
        .OrderBy(static group => group.First().IsPattern)
        .Select(static group => group.ToArray())
        .ToArray();

    private static string GetSuccessVariantName(EndPointResponse[][] variants, int index) =>
        "Body" + variants[index][0].StatusCode +
        (variants.Count(x => x[0].StatusCode == variants[index][0].StatusCode) > 1 ? "Variant" + index : string.Empty);

    private static string GetSuccessVariantType(EndPointResponse response) => response.Type.IsBinary
        ? "global::System.IO.Stream"
        : string.IsNullOrEmpty(response.Type.CSharpType) ? "object" : response.Type.CSharpTypeWithoutNullability;

    private static string GenerateSuccessResult(EndPoint endPoint)
    {
        var variants = GetSuccessVariants(endPoint);
        var name = endPoint.NotAsyncMethodName + "Result";
        return $@"
        /// <summary>
        /// A successful outcome selected by the actual HTTP status and media type.
        /// Dispose this result after consuming its binary body to release the HTTP response.
        /// </summary>
        public sealed class {name} : global::{endPoint.Settings.Namespace}.AutoSDKHttpResponse, global::System.IDisposable
        {{
            internal {name}(
                global::System.Net.HttpStatusCode statusCode,
                global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>> headers,
                global::System.Uri? requestUri{variants.Select((variant, i) => $@",
                {GetSuccessVariantType(variant[0])}? body{i} = default").Inject()})
                : base(statusCode, headers, requestUri)
            {{
{variants.Select((_, i) => $@"
                {GetSuccessVariantName(variants, i)} = body{i};").Inject()}
            }}
{variants.Select((variant, i) => $@"
            /// <summary>Gets the body for HTTP {variant[0].StatusCode}; null for other outcomes.</summary>
            public {GetSuccessVariantType(variant[0])}? {GetSuccessVariantName(variants, i)} {{ get; }}").Inject()}
            /// <summary>Releases the binary response stream, if present.</summary>
            public void Dispose()
            {{
{variants.Select((variant, i) => variant[0].Type.IsBinary ? $@"
                {GetSuccessVariantName(variants, i)}?.Dispose();" : string.Empty).Inject()}
            }}
        }}
";
    }

    private static string GetSuccessMediaCondition(string mimeType)
    {
        if (string.IsNullOrEmpty(mimeType) || mimeType == "*/*")
        {
            return "true";
        }
        if (mimeType.EndsWith("/*", StringComparison.Ordinal))
        {
            return $"__mediaType?.StartsWith({mimeType.Substring(0, mimeType.Length - 1).ToCSharpStringLiteral()}, global::System.StringComparison.OrdinalIgnoreCase) == true";
        }
        return $"global::System.String.Equals(__mediaType, {mimeType.ToCSharpStringLiteral()}, global::System.StringComparison.OrdinalIgnoreCase)";
    }

    private static string GenerateHeterogeneousResponseHandling(
        EndPoint endPoint,
        IJsonSerializer jsonSerializer,
        string cancellationToken,
        bool wrapSuccessResponse)
    {
        var variants = GetSuccessVariants(endPoint);
        using var builder = new NormalizedPooledStringBuilder(2048);
        builder.Append($@"
            if (!__response.IsSuccessStatusCode)
            {{
                var __errorContent = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    {cancellationToken}
#endif
                ).ConfigureAwait(false);
                throw global::{endPoint.GlobalSettings.Namespace}.ApiException.Create(
                    statusCode: __response.StatusCode,
                    message: __errorContent,
                    innerException: null,
                    responseBody: __errorContent,
                    responseHeaders: {GetSuccessResponseHeadersExpression(endPoint)});
            }}
            var __mediaType = __response.Content.Headers.ContentType?.MediaType;
");
        for (var index = 0; index < variants.Length; index++)
        {
            var variant = variants[index];
            var response = variant[0];
            var statusCondition = response.IsPattern
                ? $"(int)__response.StatusCode >= {response.Min} && (int)__response.StatusCode <= {response.Max}"
                : $"(int)__response.StatusCode == {response.StatusCode}";
            var mediaCondition = string.Join(" || ", variant.Select(static x => GetSuccessMediaCondition(x.MimeType)));
            builder.Append($@"
            if (({statusCondition}) && ({mediaCondition}))
            {{");
            if (response.Type.IsBinary)
            {
                builder.Append($@"
                var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    {cancellationToken}
#endif
                ).ConfigureAwait(false);
                var __body = new global::{endPoint.GlobalSettings.Namespace}.ResponseStream(__response, __stream);");
            }
            else if (string.IsNullOrEmpty(response.Type.CSharpType))
            {
                builder.Append("\n                object? __body = null;");
            }
            else
            {
                builder.Append($@"
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    {cancellationToken}
#endif
                ).ConfigureAwait(false);
                var __body = {(response.Type.CSharpTypeWithoutNullability == "string" && !response.MimeType.IsJsonMimeType()
                    ? "__content"
                    : jsonSerializer.GenerateDeserializeCall("__content", response.Type, endPoint.Settings.JsonSerializerContext) + " ?? throw new global::System.InvalidOperationException(\"Response deserialization failed.\")")};");
            }
            builder.Append($@"
                var __result = new {endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}(
                    statusCode: __response.StatusCode,
                    headers: {GetSuccessResponseHeadersExpression(endPoint)},
                    requestUri: __response.RequestMessage?.RequestUri,
                    body{index}: __body);");
            if (!response.Type.IsBinary)
            {
                builder.Append("\n                __response.Dispose();");
            }
            var returnStatement = wrapSuccessResponse
                ? $@"return new {GetResponseWrapperType(endPoint)}(
                    statusCode: __result.StatusCode,
                    headers: __result.Headers,
                    requestUri: __result.RequestUri,
                    body: __result);"
                : "return __result;";
            builder.Append($@"
                {returnStatement}
            }}
");
        }
        builder.Append($@"
            throw global::{endPoint.GlobalSettings.Namespace}.ApiException.Create(
                statusCode: __response.StatusCode,
                message: ""The successful HTTP status and Content-Type do not match a declared response contract."",
                innerException: null,
                responseBody: null,
                responseHeaders: {GetSuccessResponseHeadersExpression(endPoint)});
");
        return builder.ToString();
    }
}
