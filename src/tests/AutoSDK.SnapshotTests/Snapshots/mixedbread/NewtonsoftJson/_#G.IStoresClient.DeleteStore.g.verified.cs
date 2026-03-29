//HintName: G.IStoresClient.DeleteStore.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Delete a store<br/>
        /// Delete a store by ID or name.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store to delete.<br/>
        /// Returns:<br/>
        ///     Store: The response containing the deleted store details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreDeleted> DeleteStoreAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}