//HintName: G.IVdpClient.PipelinePublicServiceGetIntegration.g.cs
#nullable enable

namespace G
{
    public partial interface IVdpClient
    {
        /// <summary>
        /// Get an integration<br/>
        /// Returns the details of an integration.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="view"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetIntegrationResponse> PipelinePublicServiceGetIntegrationAsync(
            string integrationId,
            global::G.PipelinePublicServiceGetIntegrationView? view = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}