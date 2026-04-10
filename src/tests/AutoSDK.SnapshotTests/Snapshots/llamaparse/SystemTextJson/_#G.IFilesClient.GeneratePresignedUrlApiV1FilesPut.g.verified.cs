//HintName: G.IFilesClient.GeneratePresignedUrlApiV1FilesPut.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Generate Presigned Url<br/>
        /// Create a presigned URL for uploading a file.<br/>
        /// The URL is valid for a limited time. Use it to upload the file<br/>
        /// content directly to storage via an HTTP PUT request.
        /// </summary>
        /// <param name="expiresAtSeconds"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileIdPresignedUrl> GeneratePresignedUrlApiV1FilesPutAsync(

            global::G.FileCreate request,
            int? expiresAtSeconds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Presigned Url<br/>
        /// Create a presigned URL for uploading a file.<br/>
        /// The URL is valid for a limited time. Use it to upload the file<br/>
        /// content directly to storage via an HTTP PUT request.
        /// </summary>
        /// <param name="expiresAtSeconds"></param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="name">
        /// Name that will be used for created file. If possible, always include the file extension in the name.
        /// </param>
        /// <param name="externalFileId">
        /// The ID of the file in the external system
        /// </param>
        /// <param name="fileSize">
        /// Size of the file in bytes
        /// </param>
        /// <param name="lastModifiedAt">
        /// The last modified time of the file
        /// </param>
        /// <param name="resourceInfo">
        /// Resource information for the file
        /// </param>
        /// <param name="permissionInfo">
        /// Permission information for the file
        /// </param>
        /// <param name="dataSourceId">
        /// The ID of the data source that the file belongs to
        /// </param>
        /// <param name="storageType">
        /// Storage type for the file. Valid values: 'Ephemeral', 'Permanent' (no expiration). If not specified, defaults to permanent storage.<br/>
        /// Default Value: permanent
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileIdPresignedUrl> GeneratePresignedUrlApiV1FilesPutAsync(
            string name,
            int? expiresAtSeconds = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? externalFileId = default,
            long? fileSize = default,
            global::System.DateTime? lastModifiedAt = default,
            object? resourceInfo = default,
            object? permissionInfo = default,
            global::System.Guid? dataSourceId = default,
            global::G.AnyOf<global::G.FileCreateStorageType?, string>? storageType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}