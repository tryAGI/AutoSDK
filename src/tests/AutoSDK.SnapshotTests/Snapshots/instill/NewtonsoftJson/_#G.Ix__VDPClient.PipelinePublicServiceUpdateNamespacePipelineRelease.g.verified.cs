//HintName: G.Ix__VDPClient.PipelinePublicServiceUpdateNamespacePipelineRelease.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// Update a pipeline release<br/>
        /// Updates the details of a pipeline release, where the pipeline is<br/>
        /// identified by its resource name, formed by its parent namespace and ID.<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateNamespacePipelineReleaseResponse> PipelinePublicServiceUpdateNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            global::G.PipelineRelease request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a pipeline release<br/>
        /// Updates the details of a pipeline release, where the pipeline is<br/>
        /// identified by its resource name, formed by its parent namespace and ID.<br/>
        /// The authenticated namespace must be the parent of the pipeline in order to<br/>
        /// perform this action.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="releaseId"></param>
        /// <param name="id">
        /// Release resource ID (used in `name` as the last segment). It must be a<br/>
        /// sematic version vX.Y.Z.
        /// </param>
        /// <param name="description">
        /// Release description.
        /// </param>
        /// <param name="metadata">
        /// Key-value object with console-related data such as the pipeline builder<br/>
        /// layout.
        /// </param>
        /// <param name="readme">
        /// README.
        /// </param>
        /// <param name="rawRecipe">
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateNamespacePipelineReleaseResponse> PipelinePublicServiceUpdateNamespacePipelineReleaseAsync(
            string namespaceId,
            string pipelineId,
            string releaseId,
            string? id = default,
            string? description = default,
            object? metadata = default,
            string? readme = default,
            string? rawRecipe = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}