//HintName: G.IPromptsClient.LogPrompt.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Log Prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptLogResponse> LogPromptAsync(

            global::G.PromptLogRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Log Prompt
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="runId">
        /// Unique identifier for the Run.
        /// </param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="outputMessage"></param>
        /// <param name="promptTokens"></param>
        /// <param name="reasoningTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="promptCost"></param>
        /// <param name="outputCost"></param>
        /// <param name="finishReason"></param>
        /// <param name="messages"></param>
        /// <param name="prompt">
        /// Request to create or update a Prompt.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="output"></param>
        /// <param name="createdAt"></param>
        /// <param name="error"></param>
        /// <param name="providerLatency"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="sourceDatapointId"></param>
        /// <param name="traceParentId"></param>
        /// <param name="user"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePromptLogResponse> LogPromptAsync(
            string? versionId = default,
            string? environment = default,
            string? runId = default,
            string? path = default,
            string? id = default,
            global::G.ChatMessage? outputMessage = default,
            int? promptTokens = default,
            int? reasoningTokens = default,
            int? outputTokens = default,
            double? promptCost = default,
            double? outputCost = default,
            string? finishReason = default,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages = default,
            global::G.PromptRequest? prompt = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            string? output = default,
            global::System.DateTime? createdAt = default,
            string? error = default,
            double? providerLatency = default,
            object? inputs = default,
            string? source = default,
            object? metadata = default,
            string? sourceDatapointId = default,
            string? traceParentId = default,
            string? user = default,
            bool? save = default,
            string? logId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}