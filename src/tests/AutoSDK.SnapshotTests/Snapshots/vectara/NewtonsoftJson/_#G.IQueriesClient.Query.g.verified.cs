//HintName: G.IQueriesClient.Query.g.cs
#nullable enable

namespace G
{
    public partial interface IQueriesClient
    {
        /// <summary>
        /// Multiple Corpora Query<br/>
        /// Perform a multi-purpose query to retrieve relevant information from one or more corpora and generate a response using Retrieval Augmented Generation (RAG).<br/>
        /// * Customize your search by specifying the query text (`query`), pagination details (`offset` and `limit`), and metadata filters (`metadata_filter`) to tailor your search results. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#query-definition)<br/>
        /// * Leverage advanced search capabilities like reranking (`reranker`) and opt-in Retrieval Augmented Generation (RAG) (`generation`) for enhanced query performance. Generation is opt in by setting the `generation` property. By excluding the property or by setting it to null, the response<br/>
        /// will not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Specify a RAG-specific LLM like Mockingbird (`mockingbird-1.0-2024-07-16`) for the `generation_preset_name`. [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Use advanced summarization options that utilize detailed summarization parameters such as `max_response_characters`, `temperature`, and `frequency_penalty` for generating precise and relevant summaries. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries using the `citations` object to include numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#citation-format-in-summary)<br/>
        /// For more detailed information, see this [Query API guide](https://docs.vectara.com/docs/api-reference/search-apis/search).
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryFullResponse> QueryAsync(
            global::G.QueryRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Multiple Corpora Query<br/>
        /// Perform a multi-purpose query to retrieve relevant information from one or more corpora and generate a response using Retrieval Augmented Generation (RAG).<br/>
        /// * Customize your search by specifying the query text (`query`), pagination details (`offset` and `limit`), and metadata filters (`metadata_filter`) to tailor your search results. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#query-definition)<br/>
        /// * Leverage advanced search capabilities like reranking (`reranker`) and opt-in Retrieval Augmented Generation (RAG) (`generation`) for enhanced query performance. Generation is opt in by setting the `generation` property. By excluding the property or by setting it to null, the response<br/>
        /// will not include generation. [Learn more](https://docs.vectara.com/docs/learn/grounded-generation/configure-query-summarization)<br/>
        /// * Specify a RAG-specific LLM like Mockingbird (`mockingbird-1.0-2024-07-16`) for the `generation_preset_name`. [Learn more](https://docs.vectara.com/docs/learn/mockingbird-llm)<br/>
        /// * Use advanced summarization options that utilize detailed summarization parameters such as `max_response_characters`, `temperature`, and `frequency_penalty` for generating precise and relevant summaries. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#advanced-summarization-customization-options)<br/>
        /// * Customize citation formats in summaries using the `citations` object to include numeric, HTML, or Markdown links. [Learn more](https://docs.vectara.com/docs/api-reference/search-apis/search#citation-format-in-summary)<br/>
        /// For more detailed information, see this [Query API guide](https://docs.vectara.com/docs/api-reference/search-apis/search).
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryFullResponse> QueryAsync(
            string query,
            global::G.SearchCorporaParameters search,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.GenerationParameters? generation = default,
            bool? streamResponse = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}