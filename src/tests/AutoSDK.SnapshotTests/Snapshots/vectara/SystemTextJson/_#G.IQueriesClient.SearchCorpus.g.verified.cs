//HintName: G.IQueriesClient.SearchCorpus.g.cs
#nullable enable

namespace G
{
    public partial interface IQueriesClient
    {
        /// <summary>
        /// Simple Single Corpus Query<br/>
        /// Search a single corpus with a straightforward query request, specifying the corpus key and query parameters.<br/>
        /// * Specify the unique `corpus_key` identifying the corpus to query.<br/>
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
        global::System.Threading.Tasks.Task<global::G.QueryFullResponse> SearchCorpusAsync(
            string corpusKey,
            string query,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = 10,
            int? offset = 0,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}