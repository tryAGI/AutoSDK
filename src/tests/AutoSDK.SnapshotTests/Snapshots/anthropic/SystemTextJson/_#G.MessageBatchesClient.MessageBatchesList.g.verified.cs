//HintName: G.MessageBatchesClient.MessageBatchesList.g.cs

#nullable enable

namespace G
{
    public partial class MessageBatchesClient
    {
        partial void PrepareMessageBatchesListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? beforeId,
            ref string? afterId,
            ref int? limit,
            ref string? anthropicVersion,
            ref string? xApiKey);
        partial void PrepareMessageBatchesListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? beforeId,
            string? afterId,
            int? limit,
            string? anthropicVersion,
            string? xApiKey);
        partial void ProcessMessageBatchesListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMessageBatchesListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Message Batches<br/>
        /// List all Message Batches within a Workspace. Most recently created batches are returned first.<br/>
        /// Learn more about the Message Batches API in our [user guide](/en/docs/build-with-claude/batch-processing)
        /// </summary>
        /// <param name="beforeId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately before this object.
        /// </param>
        /// <param name="afterId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately after this object.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListResponseMessageBatch> MessageBatchesListAsync(
            string? beforeId = default,
            string? afterId = default,
            int? limit = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareMessageBatchesListArguments(
                httpClient: HttpClient,
                beforeId: ref beforeId,
                afterId: ref afterId,
                limit: ref limit,
                anthropicVersion: ref anthropicVersion,
                xApiKey: ref xApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/messages/batches",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("before_id", beforeId) 
                .AddOptionalParameter("after_id", afterId) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (anthropicVersion != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("anthropic-version", anthropicVersion.ToString());
            }
            if (xApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMessageBatchesListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                beforeId: beforeId,
                afterId: afterId,
                limit: limit,
                anthropicVersion: anthropicVersion,
                xApiKey: xApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMessageBatchesListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Error response.  See our [errors documentation](https://docs.anthropic.com/en/api/errors) for more details.
            if ((int)__response.StatusCode >= 400 && (int)__response.StatusCode <= 499)
            {
                string? __content_4XX = null;
                global::G.ErrorResponse? __value_4XX = null;
                if (ReadResponseAsString)
                {
                    __content_4XX = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_4XX = global::G.ErrorResponse.FromJson(__content_4XX, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_4XX = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_4XX = await global::G.ErrorResponse.FromJsonStreamAsync(__contentStream_4XX, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ErrorResponse>(
                    message: __content_4XX ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_4XX,
                    ResponseObject = __value_4XX,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessMessageBatchesListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListResponseMessageBatch.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListResponseMessageBatch.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
    }
}