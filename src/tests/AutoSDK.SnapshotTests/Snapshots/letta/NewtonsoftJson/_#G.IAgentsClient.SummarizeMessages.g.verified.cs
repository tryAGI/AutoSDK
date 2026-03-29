//HintName: G.IAgentsClient.SummarizeMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Summarize Messages<br/>
        /// Summarize an agent's conversation history.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CompactionResponse> SummarizeMessagesAsync(
            string agentId,

            global::G.LettaServerRestApiRoutersV1AgentsCompactionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize Messages<br/>
        /// Summarize an agent's conversation history.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CompactionResponse> SummarizeMessagesAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}