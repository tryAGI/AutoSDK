//HintName: G.QueriesClient.QueryCorpusAsStream.g.cs

#nullable enable

namespace G
{
    public partial class QueriesClient
    {
        partial void PrepareQueryCorpusAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestTimeout,
            ref int? requestTimeoutMillis,
            ref string corpusKey,
            global::G.QueryCorpusRequest request);
        partial void PrepareQueryCorpusAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestTimeout,
            int? requestTimeoutMillis,
            string corpusKey,
            global::G.QueryCorpusRequest request);
        partial void ProcessQueryCorpusAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);


        /// <summary>
        /// Advanced Single Corpus Query<br/>
        /// Perform an advanced query on a specific corpus to find relevant results, generate summaries, highlight relevant snippets, and use Retrieval Augmented Generation.<br/>
        /// This endpoint expands on the simple GET version by allowing full customization of:<br/>
        /// - **Search parameters**: Control pagination (`offset`, `limit`), apply metadata filters, and specify lexical interpolation to balance neural and keyword-based retrieval.<br/>
        /// - **Hybrid search**: Adjust the `lexical_interpolation` value between `0.0` (purely neural) and `1.0` (purely lexical). Typical best results are between `0.01` and `0.1`.<br/>
        /// - **Reranking**: Apply advanced rerankers such as Multilingual, MMR, Chain, or User Defined Function rerankers to improve result relevance.<br/>
        /// - **Generation (RAG)**: Include a `generation` object to enable grounded summarization with your own data, citations, and factual consistency scoring.<br/>
        /// - **Streaming**: Optionally stream results or generated summaries in real time with `stream_response`.<br/>
        /// Each query must include the `corpus_key` path parameter that identifies the target corpus. The response contains one or more subdocuments representing the most relevant passages, along with any generated summaries or citations.<br/>
        /// **Typical use cases**<br/>
        /// - Perform a semantically rich search over a large, domain-specific corpus.<br/>
        /// - Retrieve relevant text passages and apply reranking for better result diversity.<br/>
        /// - Generate contextually grounded answers or summaries using Retrieval Augmented Generation.<br/>
        /// ## Basic query<br/>
        /// This basic query example has a minimal configuration:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "query": "What are black holes?",<br/>
        ///   "search": {<br/>
        ///     "corpora": [{<br/>
        ///       "corpus_key": "my-corpus" <br/>
        ///     }],<br/>
        ///   },<br/>
        ///   "generation": {<br/>
        ///     "generation_preset_name": "mockingbird-2.0",<br/>
        ///     "max_used_search_results": 20 <br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ## Request body parameters<br/>
        /// The request body is a JSON object containing the `query`, `search`, and optional `generation` objects.<br/>
        /// `query` (string, required) - (Required) The search query text.<br/>
        /// `search` (string, required) - (Required) An object that controls the retrieval and reranking process.<br/>
        /// `search.corpora` - An array specifying which corpus to search. For this endpoint, the array will contain a single object.<br/>
        /// * `corpus_key` (string, required): The unique ID of the corpus to search.<br/>
        /// * `metadata_filter` (string, optional): A SQL-like filter to narrow results. For syntax and examples, see the Filters guide.<br/>
        /// * `lexical_interpolation` (float, optional): A value between 0.0 (pure neural search) and 1.0 (pure keyword search) to enable hybrid search. A recommended starting point is 0.025.<br/>
        /// * `custom_dimensions` (object, optional): An object to boost or bury results based on custom dimensions. See the Custom Dimensions guide for details.<br/>
        /// `search.limit` (integer, optional) - The maximum number of results to retrieve before reranking. **Default**: 10<br/>
        /// `search.offset` (integer, optional) - The number of results to skip for pagination. **Default**: 0<br/>
        /// `search.context_configuration` (object, optional) - Configuration for surrounding context to include with each search result.<br/>
        /// * `sentences_before` (integer): Number of sentences to include before the matching text.<br/>
        /// * `sentences_after` (integer): Number of sentences to include after the matching text.<br/>
        /// * `characters_before` (integer): Number of characters to include before the matching text.<br/>
        /// * `characters_after` (integer): Number of characters to include after the matching text.<br/>
        /// * `start_tag` (string): HTML-style tag to wrap the beginning of the retrieved context (e.g., `&lt;b&gt;`).<br/>
        /// * `end_tag` (string): HTML-style tag to wrap the end of the retrieved context (e.g., `&lt;/b&gt;`).<br/>
        /// :::note<br/>
        /// You can only use sentences before/after OR characters before/after, but not both.<br/>
        /// :::<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "context_configuration": {<br/>
        ///     "sentences_before": 2,<br/>
        ///     "sentences_after": 2,<br/>
        ///     "start_tag": "&lt;mark&gt;",<br/>
        ///     "end_tag": "&lt;/mark&gt;"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `search.reranker` (object, optional) - Configures a reranker to improve result quality by reordering search results to place the most relevant content first. For more details, see [Reranking overview](/docs/search-and-retrieval/rerankers/reranking-overview).<br/>
        /// * `type` (string): The reranker type. Options include customer_reranker (default multilingual reranker), mmr (for result diversity), or none.<br/>
        /// * `reranker_name` (string): The specific reranker model to use (e.g., Rerank_Multilingual_v1).<br/>
        /// * `limit` (integer): Maximum number of results to return after reranking.<br/>
        /// * `cutoff` (float): Minimum relevance score (between 0.0 and 1.0) for a result to be included. A typical range is 0.3-0.7.<br/>
        /// * `include_context` (boolean): If true, uses surrounding context text for more accurate reranking.<br/>
        /// **Example:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "reranker": {<br/>
        ///     "type": "customer_reranker",<br/>
        ///     "reranker_name": "Rerank_Multilingual_v1",<br/>
        ///     "limit": 50,<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `generation` (object, optional) - An object that controls how the agent creates natural language responses. If this object is excluded, summarization is disabled.<br/>
        /// `generation.generation_preset_name` (string, optional) - The name of the pre-configured prompt and LLM bundle.<br/>
        /// **Recommended Presets:**<br/>
        /// * `mockingbird-2.0`: Vectara's cutting-edge LLM for RAG.<br/>
        /// * `vectara-summary-ext-24-05-med-omni`: (gpt-4o, optimized for citations)<br/>
        /// * `vectara-summary-ext-24-05-large`: (gpt-4.0-turbo, optimized for citations)<br/>
        /// * `vectara-summary-ext-24-05-sml`: (gpt-3.5-turbo, optimized for citations)<br/>
        /// **For Tabular data:**<br/>
        /// `vectara-summary-table-query-ext-dec-2024-gpt-4o`<br/>
        /// `generation.prompt_template` (string, optional) - A custom prompt template in JSON format that defines the system and user messages for the LLM. Use this to customize the behavior of the model beyond the preset. The template can include Velocity templates with variables such as `$vectaraQueryResults` to reference retrieved search results. For more information, see [Custom prompts](/docs/prompts/vectara-prompt-engine).<br/>
        /// `generation.max_used_search_results` (integer, optional) - The maximum number of top search results to send for summarization. The number of top search results to send to the LLM for summarization. Increasing this can create a more comprehensive summary but may increase response time. **Default limit**: 25.<br/>
        /// :::caution<br/>
        /// Setting this value too high may prevent the model from generating a response.<br/>
        /// :::<br/>
        /// `generation.response_language` (string, optional) - The language code for the response (e.g. `eng`, `spa`, `deu`). Set this to `auto` to have Vectara guess the language, but we recommend specifying your preferred language for best results.<br/>
        /// `generation.citations` (object, optional) - Configuration for including citations in the generated summary.<br/>
        /// * `style` (string): Citation style. Options are `markdown`, `html`, or `none`.<br/>
        /// * `url_pattern` (string): A URL template for citation links, where `{doc.id}` will be replaced with the document ID.<br/>
        /// * `text_pattern` (string): A text template for citation display, where `{doc.title}` will be replaced with the document title.<br/>
        /// **Example:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "citations": {<br/>
        ///     "style": "markdown",<br/>
        ///     "url_pattern": "https://docs.example.com/documents/{doc.id}",<br/>
        ///     "text_pattern": "{doc.title}"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `generation.model_parameters` (object, optional) - Custom parameters for the underlying LLM that overwrites the defaults of `generation_preset_name`.<br/>
        /// * `temperature` (float): Controls randomness in the output. Higher values (e.g., 0.8) produce more creative results, while lower values (e.g., 0.2) yield more focused and deterministic outputs.<br/>
        /// * `max_tokens` (integer): The maximum number of tokens to generate in the response.<br/>
        /// * `frequency_penalty` (float): Decreases the use of repeating words, reducing repetition. **Default**: `0.0` to `1.0`.<br/>
        /// * `presence_penalty` (float): Increases the chance for the model to introduce new topics. **Default**: `0.0` to `1.0`.<br/>
        /// **Example:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "model_parameters": {<br/>
        ///     "temperature": 0.7,<br/>
        ///     "max_tokens": 500,<br/>
        ///     "frequency_penalty": 0.5,<br/>
        ///     "presence_penalty": 0.3<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `generation.enable_factual_consistency_score` (boolean): If true, includes a factual consistency score in the response to indicate how well the generated summary aligns with the retrieved documents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.QueryStreamedResponse> QueryCorpusAsStreamAsync(
            string corpusKey,

            global::G.QueryCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQueryCorpusAsStreamArguments(
                httpClient: HttpClient,
                requestTimeout: ref requestTimeout,
                requestTimeoutMillis: ref requestTimeoutMillis,
                corpusKey: ref corpusKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v2/corpora/{corpusKey}/query",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareQueryCorpusAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessQueryCorpusAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::G.QueryStreamedResponse.FromJson(__content, JsonSerializerOptions) ??
                                       throw new global::G.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }

        /// <summary>
        /// Advanced Single Corpus Query<br/>
        /// Perform an advanced query on a specific corpus to find relevant results, generate summaries, highlight relevant snippets, and use Retrieval Augmented Generation.<br/>
        /// This endpoint expands on the simple GET version by allowing full customization of:<br/>
        /// - **Search parameters**: Control pagination (`offset`, `limit`), apply metadata filters, and specify lexical interpolation to balance neural and keyword-based retrieval.<br/>
        /// - **Hybrid search**: Adjust the `lexical_interpolation` value between `0.0` (purely neural) and `1.0` (purely lexical). Typical best results are between `0.01` and `0.1`.<br/>
        /// - **Reranking**: Apply advanced rerankers such as Multilingual, MMR, Chain, or User Defined Function rerankers to improve result relevance.<br/>
        /// - **Generation (RAG)**: Include a `generation` object to enable grounded summarization with your own data, citations, and factual consistency scoring.<br/>
        /// - **Streaming**: Optionally stream results or generated summaries in real time with `stream_response`.<br/>
        /// Each query must include the `corpus_key` path parameter that identifies the target corpus. The response contains one or more subdocuments representing the most relevant passages, along with any generated summaries or citations.<br/>
        /// **Typical use cases**<br/>
        /// - Perform a semantically rich search over a large, domain-specific corpus.<br/>
        /// - Retrieve relevant text passages and apply reranking for better result diversity.<br/>
        /// - Generate contextually grounded answers or summaries using Retrieval Augmented Generation.<br/>
        /// ## Basic query<br/>
        /// This basic query example has a minimal configuration:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "query": "What are black holes?",<br/>
        ///   "search": {<br/>
        ///     "corpora": [{<br/>
        ///       "corpus_key": "my-corpus" <br/>
        ///     }],<br/>
        ///   },<br/>
        ///   "generation": {<br/>
        ///     "generation_preset_name": "mockingbird-2.0",<br/>
        ///     "max_used_search_results": 20 <br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ## Request body parameters<br/>
        /// The request body is a JSON object containing the `query`, `search`, and optional `generation` objects.<br/>
        /// `query` (string, required) - (Required) The search query text.<br/>
        /// `search` (string, required) - (Required) An object that controls the retrieval and reranking process.<br/>
        /// `search.corpora` - An array specifying which corpus to search. For this endpoint, the array will contain a single object.<br/>
        /// * `corpus_key` (string, required): The unique ID of the corpus to search.<br/>
        /// * `metadata_filter` (string, optional): A SQL-like filter to narrow results. For syntax and examples, see the Filters guide.<br/>
        /// * `lexical_interpolation` (float, optional): A value between 0.0 (pure neural search) and 1.0 (pure keyword search) to enable hybrid search. A recommended starting point is 0.025.<br/>
        /// * `custom_dimensions` (object, optional): An object to boost or bury results based on custom dimensions. See the Custom Dimensions guide for details.<br/>
        /// `search.limit` (integer, optional) - The maximum number of results to retrieve before reranking. **Default**: 10<br/>
        /// `search.offset` (integer, optional) - The number of results to skip for pagination. **Default**: 0<br/>
        /// `search.context_configuration` (object, optional) - Configuration for surrounding context to include with each search result.<br/>
        /// * `sentences_before` (integer): Number of sentences to include before the matching text.<br/>
        /// * `sentences_after` (integer): Number of sentences to include after the matching text.<br/>
        /// * `characters_before` (integer): Number of characters to include before the matching text.<br/>
        /// * `characters_after` (integer): Number of characters to include after the matching text.<br/>
        /// * `start_tag` (string): HTML-style tag to wrap the beginning of the retrieved context (e.g., `&lt;b&gt;`).<br/>
        /// * `end_tag` (string): HTML-style tag to wrap the end of the retrieved context (e.g., `&lt;/b&gt;`).<br/>
        /// :::note<br/>
        /// You can only use sentences before/after OR characters before/after, but not both.<br/>
        /// :::<br/>
        /// Example:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "context_configuration": {<br/>
        ///     "sentences_before": 2,<br/>
        ///     "sentences_after": 2,<br/>
        ///     "start_tag": "&lt;mark&gt;",<br/>
        ///     "end_tag": "&lt;/mark&gt;"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `search.reranker` (object, optional) - Configures a reranker to improve result quality by reordering search results to place the most relevant content first. For more details, see [Reranking overview](/docs/search-and-retrieval/rerankers/reranking-overview).<br/>
        /// * `type` (string): The reranker type. Options include customer_reranker (default multilingual reranker), mmr (for result diversity), or none.<br/>
        /// * `reranker_name` (string): The specific reranker model to use (e.g., Rerank_Multilingual_v1).<br/>
        /// * `limit` (integer): Maximum number of results to return after reranking.<br/>
        /// * `cutoff` (float): Minimum relevance score (between 0.0 and 1.0) for a result to be included. A typical range is 0.3-0.7.<br/>
        /// * `include_context` (boolean): If true, uses surrounding context text for more accurate reranking.<br/>
        /// **Example:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "reranker": {<br/>
        ///     "type": "customer_reranker",<br/>
        ///     "reranker_name": "Rerank_Multilingual_v1",<br/>
        ///     "limit": 50,<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `generation` (object, optional) - An object that controls how the agent creates natural language responses. If this object is excluded, summarization is disabled.<br/>
        /// `generation.generation_preset_name` (string, optional) - The name of the pre-configured prompt and LLM bundle.<br/>
        /// **Recommended Presets:**<br/>
        /// * `mockingbird-2.0`: Vectara's cutting-edge LLM for RAG.<br/>
        /// * `vectara-summary-ext-24-05-med-omni`: (gpt-4o, optimized for citations)<br/>
        /// * `vectara-summary-ext-24-05-large`: (gpt-4.0-turbo, optimized for citations)<br/>
        /// * `vectara-summary-ext-24-05-sml`: (gpt-3.5-turbo, optimized for citations)<br/>
        /// **For Tabular data:**<br/>
        /// `vectara-summary-table-query-ext-dec-2024-gpt-4o`<br/>
        /// `generation.prompt_template` (string, optional) - A custom prompt template in JSON format that defines the system and user messages for the LLM. Use this to customize the behavior of the model beyond the preset. The template can include Velocity templates with variables such as `$vectaraQueryResults` to reference retrieved search results. For more information, see [Custom prompts](/docs/prompts/vectara-prompt-engine).<br/>
        /// `generation.max_used_search_results` (integer, optional) - The maximum number of top search results to send for summarization. The number of top search results to send to the LLM for summarization. Increasing this can create a more comprehensive summary but may increase response time. **Default limit**: 25.<br/>
        /// :::caution<br/>
        /// Setting this value too high may prevent the model from generating a response.<br/>
        /// :::<br/>
        /// `generation.response_language` (string, optional) - The language code for the response (e.g. `eng`, `spa`, `deu`). Set this to `auto` to have Vectara guess the language, but we recommend specifying your preferred language for best results.<br/>
        /// `generation.citations` (object, optional) - Configuration for including citations in the generated summary.<br/>
        /// * `style` (string): Citation style. Options are `markdown`, `html`, or `none`.<br/>
        /// * `url_pattern` (string): A URL template for citation links, where `{doc.id}` will be replaced with the document ID.<br/>
        /// * `text_pattern` (string): A text template for citation display, where `{doc.title}` will be replaced with the document title.<br/>
        /// **Example:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "citations": {<br/>
        ///     "style": "markdown",<br/>
        ///     "url_pattern": "https://docs.example.com/documents/{doc.id}",<br/>
        ///     "text_pattern": "{doc.title}"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `generation.model_parameters` (object, optional) - Custom parameters for the underlying LLM that overwrites the defaults of `generation_preset_name`.<br/>
        /// * `temperature` (float): Controls randomness in the output. Higher values (e.g., 0.8) produce more creative results, while lower values (e.g., 0.2) yield more focused and deterministic outputs.<br/>
        /// * `max_tokens` (integer): The maximum number of tokens to generate in the response.<br/>
        /// * `frequency_penalty` (float): Decreases the use of repeating words, reducing repetition. **Default**: `0.0` to `1.0`.<br/>
        /// * `presence_penalty` (float): Increases the chance for the model to introduce new topics. **Default**: `0.0` to `1.0`.<br/>
        /// **Example:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "model_parameters": {<br/>
        ///     "temperature": 0.7,<br/>
        ///     "max_tokens": 500,<br/>
        ///     "frequency_penalty": 0.5,<br/>
        ///     "presence_penalty": 0.3<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// `generation.enable_factual_consistency_score` (boolean): If true, includes a factual consistency score in the response to indicate how well the generated summary aligns with the retrieved documents.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="query">
        /// The search query string, which is the question the user is asking.
        /// </param>
        /// <param name="search">
        /// The parameters to search one corpus.
        /// </param>
        /// <param name="generation">
        /// The parameters to control generation.
        /// </param>
        /// <param name="streamResponse">
        /// Indicates whether the response should be streamed or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save the query to query history.
        /// </param>
        /// <param name="intelligentQueryRewriting">
        /// [Tech Preview] Indicates whether to enable intelligent query rewriting. When enabled, the platform will attempt to extract metadata filter and rewrite the query to improve search results. Read [here](https://docs.vectara.com/docs/search-and-retrieval/intelligent-query-rewriting) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::G.QueryStreamedResponse> QueryCorpusAsStreamAsync(
            string corpusKey,
            string query,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AllOf<global::G.SearchCorpus, global::G.SearchParameters>? search = default,
            global::G.GenerationParameters? generation = default,
            bool? streamResponse = default,
            bool? saveHistory = default,
            bool? intelligentQueryRewriting = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.QueryCorpusRequest
            {
                Query = query,
                Search = search,
                Generation = generation,
                StreamResponse = streamResponse,
                SaveHistory = saveHistory,
                IntelligentQueryRewriting = intelligentQueryRewriting,
            };

            var __enumerable = QueryCorpusAsStreamAsync(
                requestTimeout: requestTimeout,
                requestTimeoutMillis: requestTimeoutMillis,
                corpusKey: corpusKey,
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}