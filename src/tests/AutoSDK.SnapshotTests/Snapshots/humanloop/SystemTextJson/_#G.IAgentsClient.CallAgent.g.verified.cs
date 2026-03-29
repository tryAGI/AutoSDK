//HintName: G.IAgentsClient.CallAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Call Agent
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentCallResponse> CallAgentAsync(

            global::G.AgentCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Agent
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="messages"></param>
        /// <param name="agent"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
        /// <param name="traceParentId"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentCallResponse> CallAgentAsync(
            string? versionId = default,
            string? environment = default,
            string? path = default,
            string? id = default,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages = default,
            global::G.AgentRequest? agent = default,
            object? inputs = default,
            string? source = default,
            object? metadata = default,
            bool? save = default,
            string? logId = default,
            string? traceParentId = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}