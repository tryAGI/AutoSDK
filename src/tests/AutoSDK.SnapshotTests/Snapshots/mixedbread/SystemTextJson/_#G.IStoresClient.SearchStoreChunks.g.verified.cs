//HintName: G.IStoresClient.SearchStoreChunks.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Perform semantic search across store chunks<br/>
        /// Perform semantic search across store chunks.<br/>
        /// This endpoint searches through store chunks using semantic similarity matching.<br/>
        /// It supports complex search queries with filters and returns relevance-scored results.<br/>
        /// For the special 'mixedbread/web' store, this endpoint performs web search using<br/>
        /// a mixture of different providers instead of semantic search. Web search results are always<br/>
        /// reranked for consistent scoring.<br/>
        /// Args:<br/>
        ///     search_params: Search configuration including:<br/>
        ///         - query text or embeddings<br/>
        ///         - store_identifiers: List of store identifiers to search<br/>
        ///         - file_ids: Optional list of file IDs to filter chunks by (or tuple of list and condition operator)<br/>
        ///         - metadata filters<br/>
        ///         - pagination parameters<br/>
        ///         - sorting preferences<br/>
        ///     _state: API state dependency<br/>
        ///     _ctx: Service context dependency<br/>
        /// Returns:<br/>
        ///     StoreSearchResponse containing:<br/>
        ///         - List of matched chunks with relevance scores<br/>
        ///         - Pagination details including total result count<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If search parameters are invalid<br/>
        ///     HTTPException (404): If no vector stores are found to search
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreSearchResponse> SearchStoreChunksAsync(

            global::G.StoreChunkSearchParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Perform semantic search across store chunks<br/>
        /// Perform semantic search across store chunks.<br/>
        /// This endpoint searches through store chunks using semantic similarity matching.<br/>
        /// It supports complex search queries with filters and returns relevance-scored results.<br/>
        /// For the special 'mixedbread/web' store, this endpoint performs web search using<br/>
        /// a mixture of different providers instead of semantic search. Web search results are always<br/>
        /// reranked for consistent scoring.<br/>
        /// Args:<br/>
        ///     search_params: Search configuration including:<br/>
        ///         - query text or embeddings<br/>
        ///         - store_identifiers: List of store identifiers to search<br/>
        ///         - file_ids: Optional list of file IDs to filter chunks by (or tuple of list and condition operator)<br/>
        ///         - metadata filters<br/>
        ///         - pagination parameters<br/>
        ///         - sorting preferences<br/>
        ///     _state: API state dependency<br/>
        ///     _ctx: Service context dependency<br/>
        /// Returns:<br/>
        ///     StoreSearchResponse containing:<br/>
        ///         - List of matched chunks with relevance scores<br/>
        ///         - Pagination details including total result count<br/>
        /// Raises:<br/>
        ///     HTTPException (400): If search parameters are invalid<br/>
        ///     HTTPException (404): If no vector stores are found to search
        /// </summary>
        /// <param name="query">
        /// Search query text
        /// </param>
        /// <param name="storeIdentifiers">
        /// IDs or names of stores to search
        /// </param>
        /// <param name="topK">
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filters">
        /// Optional filter conditions
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </param>
        /// <param name="searchOptions">
        /// Search configuration options
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreSearchResponse> SearchStoreChunksAsync(
            global::G.MultiModalQuery query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            int? topK = default,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters = default,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::G.StoreChunkSearchOptions? searchOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}