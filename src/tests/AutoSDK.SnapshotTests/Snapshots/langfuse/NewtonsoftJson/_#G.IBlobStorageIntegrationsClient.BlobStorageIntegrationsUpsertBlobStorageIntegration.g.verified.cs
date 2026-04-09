//HintName: G.IBlobStorageIntegrationsClient.BlobStorageIntegrationsUpsertBlobStorageIntegration.g.cs
#nullable enable

namespace G
{
    public partial interface IBlobStorageIntegrationsClient
    {
        /// <summary>
        /// Create or update a blob storage integration for a specific project (requires organization-scoped API key). The configuration is validated by performing a test upload to the bucket.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BlobStorageIntegrationResponse> BlobStorageIntegrationsUpsertBlobStorageIntegrationAsync(

            global::G.CreateBlobStorageIntegrationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a blob storage integration for a specific project (requires organization-scoped API key). The configuration is validated by performing a test upload to the bucket.
        /// </summary>
        /// <param name="projectId">
        /// ID of the project in which to configure the blob storage integration
        /// </param>
        /// <param name="type"></param>
        /// <param name="bucketName">
        /// Name of the storage bucket
        /// </param>
        /// <param name="endpoint">
        /// Custom endpoint URL (required for S3_COMPATIBLE type)
        /// </param>
        /// <param name="region">
        /// Storage region
        /// </param>
        /// <param name="accessKeyId">
        /// Access key ID for authentication
        /// </param>
        /// <param name="secretAccessKey">
        /// Secret access key for authentication (will be encrypted when stored)
        /// </param>
        /// <param name="prefix">
        /// Path prefix for exported files (must end with forward slash if provided)
        /// </param>
        /// <param name="exportFrequency"></param>
        /// <param name="enabled">
        /// Whether the integration is active
        /// </param>
        /// <param name="forcePathStyle">
        /// Use path-style URLs for S3 requests
        /// </param>
        /// <param name="fileType"></param>
        /// <param name="exportMode"></param>
        /// <param name="exportStartDate">
        /// Custom start date for exports (required when exportMode is FROM_CUSTOM_DATE)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BlobStorageIntegrationResponse> BlobStorageIntegrationsUpsertBlobStorageIntegrationAsync(
            string projectId,
            global::G.BlobStorageIntegrationType type,
            string bucketName,
            string region,
            global::G.BlobStorageExportFrequency exportFrequency,
            bool enabled,
            bool forcePathStyle,
            global::G.BlobStorageIntegrationFileType fileType,
            global::G.BlobStorageExportMode exportMode,
            string? endpoint = default,
            string? accessKeyId = default,
            string? secretAccessKey = default,
            string? prefix = default,
            global::System.DateTime? exportStartDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}