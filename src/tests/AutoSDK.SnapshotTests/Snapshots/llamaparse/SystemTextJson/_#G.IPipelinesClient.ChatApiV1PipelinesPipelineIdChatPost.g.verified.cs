//HintName: G.IPipelinesClient.ChatApiV1PipelinesPipelineIdChatPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Chat<br/>
        /// Chat with a managed pipeline using RAG.<br/>
        /// Combines retrieval from the pipeline's vector store with an<br/>
        /// LLM chat completion. Returns a streaming response.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ChatApiV1PipelinesPipelineIdChatPostAsync(
            global::System.Guid pipelineId,

            global::G.ChatInputParams request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat<br/>
        /// Chat with a managed pipeline using RAG.<br/>
        /// Combines retrieval from the pipeline's vector store with an<br/>
        /// LLM chat completion. Returns a streaming response.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="messages"></param>
        /// <param name="data"></param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ChatApiV1PipelinesPipelineIdChatPostAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Collections.Generic.IList<global::G.InputMessage>? messages = default,
            global::G.ChatData? data = default,
            string? className = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}