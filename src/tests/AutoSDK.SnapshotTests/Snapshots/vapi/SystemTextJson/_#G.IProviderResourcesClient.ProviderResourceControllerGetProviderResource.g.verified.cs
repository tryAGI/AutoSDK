//HintName: G.IProviderResourcesClient.ProviderResourceControllerGetProviderResource.g.cs
#nullable enable

namespace G
{
    public partial interface IProviderResourcesClient
    {
        /// <summary>
        /// Get Provider Resource
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProviderResource> ProviderResourceControllerGetProviderResourceAsync(
            global::G.ProviderResourceControllerGetProviderResourceProvider provider,
            global::G.ProviderResourceControllerGetProviderResourceResourceName resourceName,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}