//HintName: G.IPipelinesClient.PipelinesUpdatePipelineProducerConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Update Pipeline Producer Config<br/>
        /// Update the producer configuration for a pipeline (e.g., Slack channels)
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesUpdatePipelineProducerConfigResponse> PipelinesUpdatePipelineProducerConfigAsync(
            string pipelineId,

            global::G.PipelinesUpdatePipelineProducerConfigRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pipeline Producer Config<br/>
        /// Update the producer configuration for a pipeline (e.g., Slack channels)
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="producerConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesUpdatePipelineProducerConfigResponse> PipelinesUpdatePipelineProducerConfigAsync(
            string pipelineId,
            global::G.ProducerConfig2 producerConfig,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}