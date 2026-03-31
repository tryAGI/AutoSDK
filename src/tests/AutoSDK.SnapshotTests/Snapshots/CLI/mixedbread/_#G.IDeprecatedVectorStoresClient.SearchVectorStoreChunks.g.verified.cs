//HintName: G.IDeprecatedVectorStoresClient.SearchVectorStoreChunks.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Perform semantic search across vector store chunks<br/>
        /// DEPRECATED: Use POST /stores/search instead
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStoreSearchResponse> SearchVectorStoreChunksAsync(

            global::G.VectorStoreChunkSearchParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [DEPRECATED] Perform semantic search across vector store chunks<br/>
        /// DEPRECATED: Use POST /stores/search instead
        /// </summary>
        /// <param name="query">
        /// Search query text
        /// </param>
        /// <param name="vectorStoreIdentifiers">
        /// IDs or names of vector stores to search
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
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStoreSearchResponse> SearchVectorStoreChunksAsync(
            string query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> vectorStoreIdentifiers,
            int? topK = default,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters = default,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::G.VectorStoreChunkSearchOptions? searchOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}