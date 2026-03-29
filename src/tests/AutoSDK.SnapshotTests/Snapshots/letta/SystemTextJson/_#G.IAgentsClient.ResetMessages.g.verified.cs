//HintName: G.IAgentsClient.ResetMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Reset Messages<br/>
        /// Resets the messages for an agent
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> ResetMessagesAsync(
            string agentId,

            global::G.ResetMessagesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset Messages<br/>
        /// Resets the messages for an agent
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="addDefaultInitialMessages">
        /// If true, adds the default initial messages after resetting.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> ResetMessagesAsync(
            string agentId,
            bool? addDefaultInitialMessages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}