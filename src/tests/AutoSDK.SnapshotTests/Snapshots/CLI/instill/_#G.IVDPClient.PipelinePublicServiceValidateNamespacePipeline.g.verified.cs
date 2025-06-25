//HintName: G.IVDPClient.PipelinePublicServiceValidateNamespacePipeline.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// Validate a pipeline<br/>
        /// Validates a pipeline by its resource name, which is defined by the parent<br/>
        /// namespace and the ID of the pipeline.<br/>
        /// Validation checks the recipe of the pipeline and the status of its components.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateNamespacePipelineResponse> PipelinePublicServiceValidateNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            object request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Validate a pipeline<br/>
        /// Validates a pipeline by its resource name, which is defined by the parent<br/>
        /// namespace and the ID of the pipeline.<br/>
        /// Validation checks the recipe of the pipeline and the status of its components.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateNamespacePipelineResponse> PipelinePublicServiceValidateNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}