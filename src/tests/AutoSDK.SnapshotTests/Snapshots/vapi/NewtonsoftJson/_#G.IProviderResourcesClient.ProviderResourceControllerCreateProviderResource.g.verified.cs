//HintName: G.IProviderResourcesClient.ProviderResourceControllerCreateProviderResource.g.cs
#nullable enable

namespace G
{
    public partial interface IProviderResourcesClient
    {
        /// <summary>
        /// Create Provider Resource
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProviderResource> ProviderResourceControllerCreateProviderResourceAsync(
            string contentType,
            global::G.ProviderResourceControllerCreateProviderResourceProvider provider,
            global::G.ProviderResourceControllerCreateProviderResourceResourceName resourceName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}