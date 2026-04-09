//HintName: G.IDeprecatedVectorStoresClient.RetrieveVectorStoreFile.g.cs
#nullable enable

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Get vector store file<br/>
        /// DEPRECATED: Use GET /stores/{store_identifier}/files/{file_id} instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="fileId">
        /// The ID or name of the file
        /// </param>
        /// <param name="returnChunks">
        /// Whether to return the chunks for the file<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStoreFile> RetrieveVectorStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::G.AnyOf<string, global::System.Guid?> fileId,
            bool? returnChunks = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}