//HintName: G.IQueriesClient.Query2.g.cs
#nullable enable

namespace G
{
    public partial interface IQueriesClient
    {
        /// <summary>
        /// Multiple Corpora Query<br/>
        /// Perform a multipurpose query to retrieve relevant information from one or more corpora and generate a response using Retrieval Augmented Generation (RAG). Similar to the [advanced corpora search](https://docs.vectara.com/docs/rest-api/query-corpus).<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query. The `corpus_key` is created in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus), and the corpus key is part of that process. When creating a new corpus, you have the option to assign a custom `corpus_key` following your preferred naming convention. This key serves as a unique identifier for the corpus, allowing it to be referenced in search requests.<br/>
        /// * Customize your search by specifying the query text (`query`), pagination details (`offset` and `limit`), and metadata filters (`metadata_filter`) to tailor your search results.<br/>
        /// * Leverage advanced search capabilities like reranking (`reranker`) and opt-in Retrieval Augmented Generation (RAG) (`generation`) for enhanced query performance. Generation is opt-in by setting the `generation` property. By excluding the property or by setting it to null, the response will not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Specify Vectara's RAG-focused LLM (Mockingbird) for the `generation_preset_name`. [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Use advanced summarization options that utilize detailed summarization parameters such as `max_response_characters`, `temperature`, and `frequency_penalty` for generating precise and relevant summaries. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries using the `citations` object to include numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#citations)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryFullResponse> Query2Async(

            global::G.QueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Multiple Corpora Query<br/>
        /// Perform a multipurpose query to retrieve relevant information from one or more corpora and generate a response using Retrieval Augmented Generation (RAG). Similar to the [advanced corpora search](https://docs.vectara.com/docs/rest-api/query-corpus).<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query. The `corpus_key` is created in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus), and the corpus key is part of that process. When creating a new corpus, you have the option to assign a custom `corpus_key` following your preferred naming convention. This key serves as a unique identifier for the corpus, allowing it to be referenced in search requests.<br/>
        /// * Customize your search by specifying the query text (`query`), pagination details (`offset` and `limit`), and metadata filters (`metadata_filter`) to tailor your search results.<br/>
        /// * Leverage advanced search capabilities like reranking (`reranker`) and opt-in Retrieval Augmented Generation (RAG) (`generation`) for enhanced query performance. Generation is opt-in by setting the `generation` property. By excluding the property or by setting it to null, the response will not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Specify Vectara's RAG-focused LLM (Mockingbird) for the `generation_preset_name`. [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Use advanced summarization options that utilize detailed summarization parameters such as `max_response_characters`, `temperature`, and `frequency_penalty` for generating precise and relevant summaries. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries using the `citations` object to include numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/search-and-retrieval#citations)
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="query">
        /// The search query string, which is the question the user is asking.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </param>
        /// <param name="search">
        /// The parameters to search one or more corpora.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryFullResponse> Query2Async(
            string query,
            global::G.SearchCorporaParameters search,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.GenerationParameters? generation = default,
            bool? streamResponse = default,
            bool? saveHistory = default,
            bool? intelligentQueryRewriting = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}