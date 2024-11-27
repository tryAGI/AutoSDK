//HintName: G.ReposClient.ReposGetReleaseAsset.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposGetReleaseAssetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int assetId);
        partial void PrepareReposGetReleaseAssetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int assetId);
        partial void ProcessReposGetReleaseAssetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposGetReleaseAssetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a release asset<br/>
        /// To download the asset's binary content, set the `Accept` header of the request to [`application/octet-stream`](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types). The API will either redirect the client to the location, or stream it directly if possible. API clients should handle both a `200` or `302` response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ReleaseAsset> ReposGetReleaseAssetAsync(
            string owner,
            string repo,
            int assetId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposGetReleaseAssetArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                assetId: ref assetId);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/releases/assets/{assetId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposGetReleaseAssetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                assetId: assetId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposGetReleaseAssetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Resource not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.BasicError? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.BasicError.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 302)
            {
                string? __content_302 = null;
                if (ReadResponseAsString)
                {
                    __content_302 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_302 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_302,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessReposGetReleaseAssetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.ReleaseAsset.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    await global::G.ReleaseAsset.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}