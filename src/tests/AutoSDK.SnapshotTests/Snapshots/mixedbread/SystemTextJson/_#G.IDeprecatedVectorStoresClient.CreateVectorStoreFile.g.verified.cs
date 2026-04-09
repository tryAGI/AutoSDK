//HintName: G.IDeprecatedVectorStoresClient.CreateVectorStoreFile.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IDeprecatedVectorStoresClient
    {
        /// <summary>
        /// [DEPRECATED] Upload file to vector store<br/>
        /// DEPRECATED: Use POST /stores/{store_identifier}/files instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStoreFile> CreateVectorStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,

            global::G.DeprecatedStoreFileUpsertParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [DEPRECATED] Upload file to vector store<br/>
        /// DEPRECATED: Use POST /stores/{store_identifier}/files instead
        /// </summary>
        /// <param name="vectorStoreIdentifier">
        /// The ID or name of the vector store
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the file
        /// </param>
        /// <param name="config">
        /// Configuration for adding the file
        /// </param>
        /// <param name="externalId">
        /// External identifier for this file in the store
        /// </param>
        /// <param name="overwrite">
        /// If true, overwrite an existing file with the same external_id<br/>
        /// Default Value: true
        /// </param>
        /// <param name="fileId">
        /// ID of the file to add
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.VectorStoreFile> CreateVectorStoreFileAsync(
            global::G.AnyOf<string, global::System.Guid?> vectorStoreIdentifier,
            global::System.Guid fileId,
            object? metadata = default,
            global::G.StoreFileConfig2? config = default,
            string? externalId = default,
            bool? overwrite = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}