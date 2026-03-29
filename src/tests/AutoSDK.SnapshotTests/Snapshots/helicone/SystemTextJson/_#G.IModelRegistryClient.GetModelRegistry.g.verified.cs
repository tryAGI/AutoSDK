//HintName: G.IModelRegistryClient.GetModelRegistry.g.cs
#nullable enable

namespace G
{
    public partial interface IModelRegistryClient
    {
        /// <summary>
        /// Returns a comprehensive list of all AI models with their configurations, pricing, and capabilities<br/>
        /// Get all available models from the registry
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultModelRegistryResponseString> GetModelRegistryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}