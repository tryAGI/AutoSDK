//HintName: G.Ix__VDPClient.PipelinePublicServiceTriggerNamespacePipeline.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// Trigger a pipeline<br/>
        /// Triggers the execution of a pipeline synchronously, i.e., the result is<br/>
        /// sent back to the namespace right after the data is processed. This method is<br/>
        /// intended for real-time inference when low latency is of concern.<br/>
        /// The pipeline is identified by its resource name, formed by the parent namespace<br/>
        /// and ID of the pipeline.<br/>
        /// For more information, see [Run NamespacePipeline](https://www.instill.tech/docs/vdp/run).
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TriggerNamespacePipelineResponse> PipelinePublicServiceTriggerNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::G.TriggerNamespacePipelineBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger a pipeline<br/>
        /// Triggers the execution of a pipeline synchronously, i.e., the result is<br/>
        /// sent back to the namespace right after the data is processed. This method is<br/>
        /// intended for real-time inference when low latency is of concern.<br/>
        /// The pipeline is identified by its resource name, formed by the parent namespace<br/>
        /// and ID of the pipeline.<br/>
        /// For more information, see [Run NamespacePipeline](https://www.instill.tech/docs/vdp/run).
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="inputs">
        /// Pipeline input parameters, it will be deprecated soon.
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TriggerNamespacePipelineResponse> PipelinePublicServiceTriggerNamespacePipelineAsync(
            string namespaceId,
            string pipelineId,
            global::System.Collections.Generic.IList<object> inputs,
            global::System.Collections.Generic.IList<global::G.TriggerData> data,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}