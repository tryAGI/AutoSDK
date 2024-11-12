//HintName: G.IQueriesClient.SearchCorpus.g.cs
#nullable enable

namespace G
{
    public partial interface IQueriesClient
    {
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.QueryFullResponse> SearchCorpusAsync(
            string corpusKey,
            string query,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}