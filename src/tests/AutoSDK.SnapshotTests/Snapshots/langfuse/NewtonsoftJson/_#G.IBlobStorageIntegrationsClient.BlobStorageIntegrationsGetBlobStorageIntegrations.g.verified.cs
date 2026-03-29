//HintName: G.IBlobStorageIntegrationsClient.BlobStorageIntegrationsGetBlobStorageIntegrations.g.cs
#nullable enable

namespace G
{
    public partial interface IBlobStorageIntegrationsClient
    {
        /// <summary>
        /// Get all blob storage integrations for the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BlobStorageIntegrationsResponse> BlobStorageIntegrationsGetBlobStorageIntegrationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}