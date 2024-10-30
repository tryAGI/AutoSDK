//HintName: G.Ix__VDPClient.PipelinePublicServiceUpdateNamespacePipeline.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// Update a pipeline<br/>
        /// Udpates a pipeline, accessing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the pipeline. The authenticated namespace must be<br/>
        /// the parent of the pipeline in order to modify it.<br/>
        /// In REST requests, only the supplied pipeline fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateNamespacePipelineResponse> PipelinePublicServiceUpdateNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::G.Pipeline request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a pipeline<br/>
        /// Udpates a pipeline, accessing it by its resource name, which is defined by<br/>
        /// the parent namespace and the ID of the pipeline. The authenticated namespace must be<br/>
        /// the parent of the pipeline in order to modify it.<br/>
        /// In REST requests, only the supplied pipeline fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="id">
        /// Pipeline resource ID (used in `name` as the last segment). This conforms<br/>
        /// to RFC-1034, which restricts to letters, numbers, and hyphen, with the<br/>
        /// first character a letter, the last a letter or a number, and a 63<br/>
        /// character maximum.
        /// </param>
        /// <param name="description">
        /// Pipeline description.
        /// </param>
        /// <param name="recipe">
        /// Recipe describes the components of a Pipeline and how they are connected.
        /// </param>
        /// <param name="sharing">
        /// Pipeline sharing information.
        /// </param>
        /// <param name="metadata">
        /// Metadata holds console-related data such as the pipeline builder layout.
        /// </param>
        /// <param name="readme">
        /// README holds the pipeline documentation.
        /// </param>
        /// <param name="tags">
        /// Tags.
        /// </param>
        /// <param name="rawRecipe">
        /// Recipe in YAML format describes the components of a pipeline and how they<br/>
        /// are connected.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the pipeline (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the pipeline is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Pipeline profile image in base64 format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateNamespacePipelineResponse> PipelinePublicServiceUpdateNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            object recipe,
            string? id = default,
            string? description = default,
            global::G.Sharing? sharing = default,
            object? metadata = default,
            string? readme = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? rawRecipe = default,
            string? sourceUrl = default,
            string? documentationUrl = default,
            string? license = default,
            string? profileImage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}