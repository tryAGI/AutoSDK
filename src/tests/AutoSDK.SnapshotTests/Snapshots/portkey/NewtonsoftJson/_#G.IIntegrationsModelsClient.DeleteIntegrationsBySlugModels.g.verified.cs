//HintName: G.IIntegrationsModelsClient.DeleteIntegrationsBySlugModels.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationsModelsClient
    {
        /// <summary>
        /// Bulk delete integration custom models<br/>
        /// Removes multiple custom models from an integration by their slugs.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="slugs">
        /// Example: gpt-4,gpt-3.5-turbo
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteIntegrationsBySlugModelsAsync(
            string slug,
            string slugs,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}