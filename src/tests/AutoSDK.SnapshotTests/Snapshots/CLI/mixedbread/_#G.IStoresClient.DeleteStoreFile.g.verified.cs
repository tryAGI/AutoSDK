//HintName: G.IStoresClient.DeleteStoreFile.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Delete store file<br/>
        /// Delete a file from a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     file_id: The ID or name of the file to delete.<br/>
        /// Returns:<br/>
        ///     VectorStoreFileDeleted: The deleted file details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="fileIdentifier">
        /// The ID or name of the file to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreFileDeleted> DeleteStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}