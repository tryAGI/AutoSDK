//HintName: G.IStoresClient.SearchStoreFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Search store files<br/>
        /// Search for files within a store based on semantic similarity.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to search within<br/>
        ///     search_params: Search configuration including query text, pagination, and filters<br/>
        /// Returns:<br/>
        ///     StoreFileSearchResponse: List of matching files with relevance scores
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreFileSearchResponse> SearchStoreFilesAsync(

            global::G.StoreFileSearchParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search store files<br/>
        /// Search for files within a store based on semantic similarity.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to search within<br/>
        ///     search_params: Search configuration including query text, pagination, and filters<br/>
        /// Returns:<br/>
        ///     StoreFileSearchResponse: List of matching files with relevance scores
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
        global::System.Threading.Tasks.Task<global::G.StoreFileSearchResponse> SearchStoreFilesAsync(
            global::G.MultiModalQuery query,
            global::System.Collections.Generic.IList<global::G.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            int? topK = default,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? filters = default,
            global::G.AnyOf<byte[], global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds = default,
            global::G.StoreFileSearchOptions? searchOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}