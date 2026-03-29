//HintName: G.IAgentsClient.LogAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Log Agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLogResponse> LogAgentAsync(

            global::G.LogAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Log Agent
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="outputMessage"></param>
        /// <param name="messages"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="promptTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="traceParentId"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLogResponse> LogAgentAsync(
            string? versionId = default,
            string? environment = default,
            string? path = default,
            string? id = default,
            string? output = default,
            global::G.ChatMessage? outputMessage = default,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages = default,
            object? inputs = default,
            string? source = default,
            object? metadata = default,
            int? promptTokens = default,
            int? outputTokens = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            string? error = default,
            string? traceParentId = default,
            bool? save = default,
            string? logId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}