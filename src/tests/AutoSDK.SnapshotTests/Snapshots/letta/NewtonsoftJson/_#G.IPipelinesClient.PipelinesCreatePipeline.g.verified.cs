//HintName: G.IPipelinesClient.PipelinesCreatePipeline.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Create Pipeline<br/>
        /// Create a new pipeline (producer + feed + optionally subscribers)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesCreatePipelineResponse> PipelinesCreatePipelineAsync(

            global::G.PipelinesCreatePipelineRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Pipeline<br/>
        /// Create a new pipeline (producer + feed + optionally subscribers)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="integrationType"></param>
        /// <param name="producerConfig"></param>
        /// <param name="subscriberAgentIds"></param>
        /// <param name="subscriberCronSchedule"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinesCreatePipelineResponse> PipelinesCreatePipelineAsync(
            string name,
            string projectId,
            global::G.PipelinesCreatePipelineRequestIntegrationType integrationType,
            global::G.ProducerConfig producerConfig,
            global::System.Collections.Generic.IList<string>? subscriberAgentIds = default,
            string? subscriberCronSchedule = default,
            string? promptTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}