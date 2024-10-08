//HintName: G.APIKeysClient.ListApiKeys.g.cs

#nullable enable

namespace G
{
    public partial class APIKeysClient
    {
        partial void PrepareListApiKeysArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref int? limit,
            ref string? pageKey,
            ref string? corpusKey);
        partial void PrepareListApiKeysRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            int? limit,
            string? pageKey,
            string? corpusKey);
        partial void ProcessListApiKeysResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListApiKeysResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List API keys
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListApiKeysResponse> ListApiKeysAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = 10,
            string? pageKey = default,
            string? corpusKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListApiKeysArguments(
                httpClient: _httpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                limit: ref limit,
                pageKey: ref pageKey,
                corpusKey: ref corpusKey);

            var __pathBuilder = new PathBuilder(
                path: "/v2/api_keys",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("page_key", pageKey) 
                .AddOptionalParameter("corpus_key", corpusKey) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            if (requestTimeout != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("Request-Timeout", requestTimeout.ToString());
            }
            if (requestTimeoutMillis != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("Request-Timeout-Millis", requestTimeoutMillis.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListApiKeysRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                limit: limit,
                pageKey: pageKey,
                corpusKey: corpusKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListApiKeysResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListApiKeysResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListApiKeysResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}