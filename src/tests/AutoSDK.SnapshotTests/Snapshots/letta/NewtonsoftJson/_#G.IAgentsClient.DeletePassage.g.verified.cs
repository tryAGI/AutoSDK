//HintName: G.IAgentsClient.DeletePassage.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Delete Passage<br/>
        /// Delete a memory from an agent's archival memory store.
        /// </summary>
        /// <param name="memoryId"></param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePassageAsync(
            string memoryId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}