//HintName: G.IStoresClient.ListStoreFilesWithMetadataFilter.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// List store files with metadata filter<br/>
        /// List files indexed in a vector store with pagination and metadata filter.<br/>
        /// Args:<br/>
        ///     vector_store_identifier: The ID or name of the vector store<br/>
        ///     pagination: Pagination parameters and metadata filter<br/>
        /// Returns:<br/>
        ///     VectorStoreFileListResponse: Paginated list of vector store files
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreFileListResponse> ListStoreFilesWithMetadataFilterAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,

            global::G.SearchCursorPagination request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List store files with metadata filter<br/>
        /// List files indexed in a vector store with pagination and metadata filter.<br/>
        /// Args:<br/>
        ///     vector_store_identifier: The ID or name of the vector store<br/>
        ///     pagination: Pagination parameters and metadata filter<br/>
        /// Returns:<br/>
        ///     VectorStoreFileListResponse: Paginated list of vector store files
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </param>
        /// <param name="before">
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="statuses">
        /// Status to filter by
        /// </param>
        /// <param name="metadataFilter">
        /// Metadata filter to apply to the query
        /// </param>
        /// <param name="q">
        /// Search query for fuzzy matching over name and external_id fields
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreFileListResponse> ListStoreFilesWithMetadataFilterAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            int? limit = default,
            string? after = default,
            string? before = default,
            bool? includeTotal = default,
            global::System.Collections.Generic.IList<global::G.StoreFileStatus>? statuses = default,
            global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>? metadataFilter = default,
            string? q = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}