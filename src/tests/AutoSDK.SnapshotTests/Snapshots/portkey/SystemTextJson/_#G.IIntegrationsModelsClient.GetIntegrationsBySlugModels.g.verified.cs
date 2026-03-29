//HintName: G.IIntegrationsModelsClient.GetIntegrationsBySlugModels.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationsModelsClient
    {
        /// <summary>
        /// List integration models<br/>
        /// Retrieves all model access for a specific integration with their configuration and pricing details.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IntegrationModelsResponse> GetIntegrationsBySlugModelsAsync(
            string slug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}