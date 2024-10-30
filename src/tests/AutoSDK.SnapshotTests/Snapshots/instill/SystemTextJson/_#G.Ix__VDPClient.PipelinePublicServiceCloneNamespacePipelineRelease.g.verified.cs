//HintName: G.Ix__VDPClient.PipelinePublicServiceCloneNamespacePipelineRelease.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// Clone a pipeline release<br/>
        /// Clones a pipeline release owned by a namespace. The new pipeline may have a different<br/>
        /// parent, and this can be either a namespace or an organization.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceCloneNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            global::G.CloneNamespacePipelineReleaseBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Clone a pipeline release<br/>
        /// Clones a pipeline release owned by a namespace. The new pipeline may have a different<br/>
        /// parent, and this can be either a namespace or an organization.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="targetNamespaceId">
        /// Target Namespace ID.
        /// </param>
        /// <param name="targetPipelineId">
        /// Target Pipeline ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PipelinePublicServiceCloneNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            string targetNamespaceId,
            string targetPipelineId,
            string? description = default,
            global::G.Sharing? sharing = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}