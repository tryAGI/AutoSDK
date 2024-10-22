//HintName: G.QueriesClient.SearchCorpus.g.cs

#nullable enable

namespace G
{
    public partial class QueriesClient
    {
        partial void PrepareSearchCorpusArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string corpusKey,
            ref string query,
            ref int? limit,
            ref int? offset);
        partial void PrepareSearchCorpusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string corpusKey,
            string query,
            int? limit,
            int? offset);
        partial void ProcessSearchCorpusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchCorpusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Simple Single Corpus Query<br/>
        /// Search a single corpus with a straightforward query request, specifying the corpus key and query parameters.<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query. The `corpus_key` is <br/>
        /// [created in the Vectara Console UI](https://docs.vectara.com/docs/console-ui/creating-a-corpus) or the [Create Corpus API definition](https://docs.vectara.com/docs/api-reference/admin-apis/create-corpus). When creating a new corpus, you have the option to assign a custom `corpus_key` following your preferred naming convention. This key serves as a unique identifier for the corpus, allowing it to be referenced in search requests. For more information, see [Corpus Key Definition](https://docs.vectara.com/docs/api-reference/search-apis/search#corpus-key-definition).<br/>
        /// * Enter the search `query` string for the corpus, which is the question you want to ask.<br/>
        /// * Set the maximum number of results (`limit`) to return. **Default**: 10, **minimum**: 1<br/>
        /// * Define the `offset` position from which to start in the result set.<br/>
        /// For more detailed information, see this [Query API guide](https://docs.vectara.com/docs/api-reference/search-apis/search).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="query"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.QueryFullResponse> SearchCorpusAsync(
            string corpusKey,
            string query,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = 10,
            int? offset = 0,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSearchCorpusArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                corpusKey: ref corpusKey,
                query: ref query,
                limit: ref limit,
                offset: ref offset);

            var __pathBuilder = new PathBuilder(
                path: $"/v2/corpora/{corpusKey}/query",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("query", query) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
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
            PrepareSearchCorpusRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                query: query,
                limit: limit,
                offset: offset);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSearchCorpusResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessSearchCorpusResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.QueryFullResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}