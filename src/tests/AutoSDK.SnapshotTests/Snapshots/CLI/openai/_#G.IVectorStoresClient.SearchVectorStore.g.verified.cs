//HintName: G.IVectorStoresClient.SearchVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Search a vector store for relevant chunks based on a query and file attributes filter.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreSearchResultsPage> SearchVectorStoreAsync(
            string vectorStoreId,
            global::G.VectorStoreSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search a vector store for relevant chunks based on a query and file attributes filter.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="query">
        /// A query string for a search
        /// </param>
        /// <param name="rewriteQuery">
        /// Whether to rewrite the natural language query for vector search.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxNumResults">
        /// The maximum number of results to return. This number should be between 1 and 50 inclusive.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filters">
        /// A filter to apply based on file attributes.
        /// </param>
        /// <param name="rankingOptions">
        /// Ranking options for search.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreSearchResultsPage> SearchVectorStoreAsync(
            string vectorStoreId,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> query,
            bool? rewriteQuery = default,
            int? maxNumResults = default,
            global::G.OneOf<global::G.ComparisonFilter, global::G.CompoundFilter>? filters = default,
            global::G.VectorStoreSearchRequestRankingOptions? rankingOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}