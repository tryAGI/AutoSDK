﻿//HintName: G.IVDPClient.PipelinePublicServiceGetIntegration.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Get an integration<br/>
        /// Returns the details of an integration.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetIntegrationResponse> PipelinePublicServiceGetIntegrationAsync(
            string integrationId,
            global::G.PipelinePublicServiceGetIntegrationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}