//HintName: G.IVDPClient.PipelinePublicServiceDeleteNamespacePipelineRelease.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Delete a pipeline release<br/>
        /// Deletes a pipeline release, where the pipeline is identified by its<br/>
        /// resource name, formed by its parent namespace and ID.<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceDeleteNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}