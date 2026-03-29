//HintName: G.IStoresClient.UploadStoreFile.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Upload file via form to store<br/>
        /// Upload a file via form to a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     config: The config for the file.<br/>
        ///     metadata: The metadata for the file.<br/>
        ///     file: The file to upload.<br/>
        /// Returns:<br/>
        ///     VectorStoreFile: The uploaded file details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreFile> UploadStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,

            global::G.BodyUploadStoreFile request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload file via form to store<br/>
        /// Upload a file via form to a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     config: The config for the file.<br/>
        ///     metadata: The metadata for the file.<br/>
        ///     file: The file to upload.<br/>
        /// Returns:<br/>
        ///     VectorStoreFile: The uploaded file details.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="file">
        /// The file to upload and index
        /// </param>
        /// <param name="filename">
        /// The file to upload and index
        /// </param>
        /// <param name="params"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreFile> UploadStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            byte[] file,
            string filename,
            string? @params = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}