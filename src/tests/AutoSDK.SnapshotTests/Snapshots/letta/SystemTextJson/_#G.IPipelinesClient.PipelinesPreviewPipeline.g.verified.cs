//HintName: G.IPipelinesClient.PipelinesPreviewPipeline.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Preview Pipeline<br/>
        /// Fetch sample messages from integration to preview what agents will receive
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesPreviewPipelineResponse> PipelinesPreviewPipelineAsync(

            global::G.PipelinesPreviewPipelineRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Pipeline<br/>
        /// Fetch sample messages from integration to preview what agents will receive
        /// </summary>
        /// <param name="integrationType"></param>
        /// <param name="integrationId"></param>
        /// <param name="producerConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesPreviewPipelineResponse> PipelinesPreviewPipelineAsync(
            global::G.PipelinesPreviewPipelineRequestIntegrationType integrationType,
            string integrationId,
            global::G.ProducerConfig3 producerConfig,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}