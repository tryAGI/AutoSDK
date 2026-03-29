//HintName: G.IStoresClient.UpdateStoreFile.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Update store file metadata<br/>
        /// Update metadata on a file within a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     file_identifier: The ID or name of the file to update.<br/>
        ///     update_params: Metadata update payload.<br/>
        /// Returns:<br/>
        ///     StoreFile: The updated file details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="fileIdentifier">
        /// The ID or name of the file to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreFile> UpdateStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,

            global::G.StoreFileMetadataUpdateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update store file metadata<br/>
        /// Update metadata on a file within a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     file_identifier: The ID or name of the file to update.<br/>
        ///     update_params: Metadata update payload.<br/>
        /// Returns:<br/>
        ///     StoreFile: The updated file details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="fileIdentifier">
        /// The ID or name of the file to update
        /// </param>
        /// <param name="metadata">
        /// Updated metadata for the file
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreFile> UpdateStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileIdentifier,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}