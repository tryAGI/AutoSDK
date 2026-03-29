//HintName: G.ICorporaClient.Search.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Simple Single Corpus Query<br/>
        /// The [**Query APIs**](/docs/rest-api/queries) enable Retrieval Augmented Generation (RAG), allowing you to search your data and generate AI-powered summaries. Vectara provides three query types to match different search needs:<br/>
        /// * [**Single corpus query**](/docs/rest-api/search-corpus): For a simple search within a single data source.<br/>
        /// * [**Advanced single corpus query**](/docs/rest-api/query-corpus): For full-featured search and RAG within one corpus, supporting advanced features like table summarization, metadata filtering, and reranking.<br/>
        /// * [**Multiple corpora query**](/docs/rest-api/query): For searching across one or more corpora with full RAG capabilities.<br/>
        /// Search a single corpus with a straightforward query request, specifying the corpus key and query parameters.<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query. The `corpus_key` is created in the Vectara Console or the [Create Corpus API](https://docs.vectara.com/docs/rest-api/create-corpus), and the corpus key is part of that process. When creating a new corpus, you have the option to assign a custom `corpus_key` following your preferred naming convention. This key serves as a unique identifier for the corpus, allowing it to be referenced in search requests.<br/>
        /// * Enter the search `query` string for the corpus, which is the question you want to ask.<br/>
        /// * Set the maximum number of results (`limit`) to return. **Default**: 10, **minimum**: 1
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
        /// <param name="saveHistory"></param>
        /// <param name="intelligentQueryRewriting">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryFullResponse> SearchAsync(
            string corpusKey,
            string query,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            int? offset = default,
            bool? saveHistory = default,
            bool? intelligentQueryRewriting = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}