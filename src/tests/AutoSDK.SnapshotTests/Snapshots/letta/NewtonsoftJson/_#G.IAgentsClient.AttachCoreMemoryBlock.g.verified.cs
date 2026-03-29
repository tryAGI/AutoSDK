//HintName: G.IAgentsClient.AttachCoreMemoryBlock.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Attach Block To Agent<br/>
        /// Attach a core memory block to an agent.
        /// </summary>
        /// <param name="blockId">
        /// The ID of the block in the format 'block-&lt;uuid4&gt;'
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> AttachCoreMemoryBlockAsync(
            string blockId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}