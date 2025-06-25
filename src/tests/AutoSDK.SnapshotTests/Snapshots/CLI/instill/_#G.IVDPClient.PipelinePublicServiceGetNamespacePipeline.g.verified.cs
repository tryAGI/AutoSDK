﻿//HintName: G.IVDPClient.PipelinePublicServiceGetNamespacePipeline.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Get a pipeline<br/>
        /// Returns the details of a pipeline.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetNamespacePipelineResponse> PipelinePublicServiceGetNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::G.PipelinePublicServiceGetNamespacePipelineView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}