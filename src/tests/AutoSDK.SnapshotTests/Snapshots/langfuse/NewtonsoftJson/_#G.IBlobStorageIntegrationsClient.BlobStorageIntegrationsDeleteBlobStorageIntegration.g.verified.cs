//HintName: G.IBlobStorageIntegrationsClient.BlobStorageIntegrationsDeleteBlobStorageIntegration.g.cs
#nullable enable

namespace G
{
    public partial interface IBlobStorageIntegrationsClient
    {
        /// <summary>
        /// Delete a blob storage integration by ID (requires organization-scoped API key)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BlobStorageIntegrationDeletionResponse> BlobStorageIntegrationsDeleteBlobStorageIntegrationAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}