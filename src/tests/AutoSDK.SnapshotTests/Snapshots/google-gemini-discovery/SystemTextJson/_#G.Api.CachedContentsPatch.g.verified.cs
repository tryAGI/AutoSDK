//HintName: G.Api.CachedContentsPatch.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCachedContentsPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string cachedContentsId,
            ref string? updateMask,
            global::G.CachedContent request);
        partial void PrepareCachedContentsPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string cachedContentsId,
            string? updateMask,
            global::G.CachedContent request);
        partial void ProcessCachedContentsPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCachedContentsPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates CachedContent resource (only expiration is updatable).
        /// </summary>
        /// <param name="cachedContentsId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CachedContent> CachedContentsPatchAsync(
            string cachedContentsId,

            global::G.CachedContent request,
            string? updateMask = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCachedContentsPatchArguments(
                httpClient: HttpClient,
                cachedContentsId: ref cachedContentsId,
                updateMask: ref updateMask,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/cachedContents/{cachedContentsId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("updateMask", updateMask) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCachedContentsPatchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cachedContentsId: cachedContentsId,
                updateMask: updateMask,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCachedContentsPatchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCachedContentsPatchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.CachedContent.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.CachedContent.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Updates CachedContent resource (only expiration is updatable).
        /// </summary>
        /// <param name="cachedContentsId"></param>
        /// <param name="updateMask"></param>
        /// <param name="expireTime">
        /// Timestamp in UTC of when this resource is considered expired. This is *always* provided on output, regardless of what was sent on input.
        /// </param>
        /// <param name="ttl">
        /// Input only. New TTL for this resource, input only.
        /// </param>
        /// <param name="displayName">
        /// Optional. Immutable. The user-generated meaningful display name of the cached content. Maximum 128 Unicode characters.
        /// </param>
        /// <param name="model">
        /// Required. Immutable. The name of the `Model` to use for cached content Format: `models/{model}`
        /// </param>
        /// <param name="systemInstruction">
        /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
        /// </param>
        /// <param name="contents">
        /// Optional. Input only. Immutable. The content to cache.
        /// </param>
        /// <param name="tools">
        /// Optional. Input only. Immutable. A list of `Tools` the model may use to generate the next response
        /// </param>
        /// <param name="toolConfig">
        /// The Tool configuration containing parameters for specifying `Tool` use in the request.
        /// </param>
        /// <param name="usageMetadata">
        /// Metadata on the usage of the cached content.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CachedContent> CachedContentsPatchAsync(
            string cachedContentsId,
            string? updateMask = default,
            string? expireTime = default,
            string? ttl = default,
            string? displayName = default,
            string? model = default,
            global::G.Content? systemInstruction = default,
            global::System.Collections.Generic.IList<global::G.Content>? contents = default,
            global::System.Collections.Generic.IList<global::G.Tool>? tools = default,
            global::G.ToolConfig? toolConfig = default,
            global::G.CachedContentUsageMetadata? usageMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::G.CachedContent
            {
                ExpireTime = expireTime,
                Ttl = ttl,
                DisplayName = displayName,
                Model = model,
                SystemInstruction = systemInstruction,
                Contents = contents,
                Tools = tools,
                ToolConfig = toolConfig,
                UsageMetadata = usageMetadata,
            };

            return await CachedContentsPatchAsync(
                cachedContentsId: cachedContentsId,
                updateMask: updateMask,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}