//HintName: G.IVDPClient.PipelinePublicServiceGetNamespacePipelineRelease.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Get a pipeline release<br/>
        /// Gets the details of a pipeline release, where the pipeline is identified<br/>
        /// by its resource name, formed by its parent namespace and ID.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetNamespacePipelineReleaseResponse> PipelinePublicServiceGetNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            global::G.PipelinePublicServiceGetNamespacePipelineReleaseView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}