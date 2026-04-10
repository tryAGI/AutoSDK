//HintName: G.IDeprecatedVectorStoresClient.DeleteVectorStoreFile.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Delete vector store file<br/>
        /// DEPRECATED: Use DELETE /stores/{store_identifier}/files/{file_id} instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="fileId">
        /// The ID or name of the file to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStoreFileDeleted> DeleteVectorStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}