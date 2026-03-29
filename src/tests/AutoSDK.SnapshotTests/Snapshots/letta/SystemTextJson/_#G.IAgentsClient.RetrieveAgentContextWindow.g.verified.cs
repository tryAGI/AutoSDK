//HintName: G.IAgentsClient.RetrieveAgentContextWindow.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Retrieve Agent Context Window<br/>
        /// Retrieve the context window of a specific agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="conversationId">
        /// Conversation ID to get context window for. If provided, uses messages from this conversation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.ContextWindowOverview> RetrieveAgentContextWindowAsync(
            string agentId,
            string? conversationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}