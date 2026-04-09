//HintName: G.IStoresClient.UpdateStore.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Update a store<br/>
        /// Update a store by ID or name.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to update.<br/>
        ///     store_update: StoreCreate object containing the name, description, and metadata.<br/>
        /// Returns:<br/>
        ///     Store: The response containing the updated store details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Store> UpdateStoreAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,

            global::G.StoreUpdateParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a store<br/>
        /// Update a store by ID or name.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to update.<br/>
        ///     store_update: StoreCreate object containing the name, description, and metadata.<br/>
        /// Returns:<br/>
        ///     Store: The response containing the updated store details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="name">
        /// New name for the store. Can only contain lowercase letters, numbers, periods (.), and hyphens (-).
        /// </param>
        /// <param name="description">
        /// New description
        /// </param>
        /// <param name="isPublic">
        /// Whether the store can be accessed by anyone with valid login credentials
        /// </param>
        /// <param name="expiresAfter">
        /// Optional expiration policy
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Store> UpdateStoreAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            string? name = default,
            string? description = default,
            bool? isPublic = default,
            global::G.ExpiresAfter? expiresAfter = default,
            object? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}