//HintName: G.IVdpClient.PipelinePublicServiceValidateNamespacePipeline.g.cs
#nullable enable

namespace G
{
    public partial interface IVdpClient
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateNamespacePipelineResponse> PipelinePublicServiceValidateNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,

            global::G.ValidateNamespacePipelineBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate a pipeline<br/>
        /// Validates a pipeline by its resource name, which is defined by the parent<br/>
        /// namespace and the ID of the pipeline.<br/>
        /// Validation checks the recipe of the pipeline and the status of its components.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateNamespacePipelineResponse> PipelinePublicServiceValidateNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}