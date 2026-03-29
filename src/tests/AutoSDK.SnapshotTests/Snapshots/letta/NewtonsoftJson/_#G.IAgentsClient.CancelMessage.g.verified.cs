//HintName: G.IAgentsClient.CancelMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Cancel Message<br/>
        /// Cancel runs associated with an agent. If run_ids are passed in, cancel those in particular.<br/>
        /// Note to cancel active runs associated with an agent, redis is required.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelMessageAsync(
            string agentId,

            global::G.CancelAgentRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Message<br/>
        /// Cancel runs associated with an agent. If run_ids are passed in, cancel those in particular.<br/>
        /// Note to cancel active runs associated with an agent, redis is required.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="runIds">
        /// Optional list of run IDs to cancel
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CancelMessageAsync(
            string agentId,
            global::System.Collections.Generic.IList<string>? runIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}