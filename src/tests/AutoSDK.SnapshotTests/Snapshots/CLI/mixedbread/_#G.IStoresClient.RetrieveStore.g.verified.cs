//HintName: G.IStoresClient.RetrieveStore.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Get a store<br/>
        /// Get a store by ID or name.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to retrieve.<br/>
        /// Returns:<br/>
        ///     Store: The response containing the store details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Store> RetrieveStoreAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}