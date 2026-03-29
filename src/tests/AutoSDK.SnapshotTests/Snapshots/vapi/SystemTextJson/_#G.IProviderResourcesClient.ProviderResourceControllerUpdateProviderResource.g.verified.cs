//HintName: G.IProviderResourcesClient.ProviderResourceControllerUpdateProviderResource.g.cs
#nullable enable

namespace G
{
    public partial interface IProviderResourcesClient
    {
        /// <summary>
        /// Update Provider Resource
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProviderResource> ProviderResourceControllerUpdateProviderResourceAsync(
            global::G.ProviderResourceControllerUpdateProviderResourceProvider provider,
            global::G.ProviderResourceControllerUpdateProviderResourceResourceName resourceName,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}