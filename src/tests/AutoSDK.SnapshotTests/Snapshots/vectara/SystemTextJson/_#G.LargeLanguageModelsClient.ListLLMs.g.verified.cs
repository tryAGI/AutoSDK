//HintName: G.LargeLanguageModelsClient.ListLLMs.g.cs

#nullable enable

namespace G
{
    public partial class LargeLanguageModelsClient
    {
        partial void PrepareListLLMsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string? filter,
            ref int? limit,
            ref string? pageKey);
        partial void PrepareListLLMsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string? filter,
            int? limit,
            string? pageKey);
        partial void ProcessListLLMsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListLLMsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List LLMs<br/>
        /// List LLMs that can be used with query and chat endpoints. The LLM is not directly specified in a query,<br/>
        /// but instead a `generation_preset_name` is used. The `generation_preset_name` property in generation parameters<br/>
        /// can be found as the `name` property on the Generations Presets retrieved from `/v2/generation_presets`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListLLMsResponse> ListLLMsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListLLMsArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                filter: ref filter,
                limit: ref limit,
                pageKey: ref pageKey);

            var __pathBuilder = new PathBuilder(
                path: "/v2/llms",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("page_key", pageKey) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (requestTimeout != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (requestTimeoutMillis != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListLLMsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                filter: filter,
                limit: limit,
                pageKey: pageKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListLLMsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Permissions do not allow listing summarizers.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.Error? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.Error.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.Error.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.Error>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessListLLMsResponseContent(
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
                    global::G.ListLLMsResponse.FromJson(__content, JsonSerializerOptions) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.ListLLMsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}