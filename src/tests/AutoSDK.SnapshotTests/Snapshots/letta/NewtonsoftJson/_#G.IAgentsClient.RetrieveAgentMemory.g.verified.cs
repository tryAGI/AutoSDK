//HintName: G.IAgentsClient.RetrieveAgentMemory.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Retrieve Agent Memory<br/>
        /// Retrieve the memory state of a specific agent.<br/>
        /// This endpoint fetches the current memory state of the agent identified by the user ID and agent ID.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Memory> RetrieveAgentMemoryAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}