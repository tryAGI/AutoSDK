//HintName: G.Ix__VDPClient.PipelinePublicServiceTriggerNamespacePipelineWithStream.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// Trigger a pipeline via streaming<br/>
        /// Triggers the execution of a pipeline asynchronously and streams back the response.<br/>
        /// This method is intended for real-time inference when low latency is of concern<br/>
        /// and the response needs to be processed incrementally.<br/>
        /// The pipeline is identified by its resource name, formed by the parent namespace<br/>
        /// and ID of the pipeline.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse> PipelinePublicServiceTriggerNamespacePipelineWithStreamAsync(
            string namespaceId,
            string pipelineId,
            global::G.TriggerNamespacePipelineWithStreamBody request,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Trigger a pipeline via streaming<br/>
        /// Triggers the execution of a pipeline asynchronously and streams back the response.<br/>
        /// This method is intended for real-time inference when low latency is of concern<br/>
        /// and the response needs to be processed incrementally.<br/>
        /// The pipeline is identified by its resource name, formed by the parent namespace<br/>
        /// and ID of the pipeline.
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
        global::System.Threading.Tasks.Task<global::G.PipelinePublicServiceTriggerNamespacePipelineWithStreamResponse> PipelinePublicServiceTriggerNamespacePipelineWithStreamAsync(
            string namespaceId,
            string pipelineId,
            string? instillRequesterUid = default,
            global::System.Collections.Generic.IList<object>? inputs = default,
            global::System.Collections.Generic.IList<global::G.TriggerData>? data = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}