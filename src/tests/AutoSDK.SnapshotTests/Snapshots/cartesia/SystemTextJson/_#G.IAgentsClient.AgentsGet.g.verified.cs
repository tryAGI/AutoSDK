//HintName: G.IAgentsClient.AgentsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get Agent<br/>
        /// Returns the details of a specific agent. To create an agent, use the CLI or the Playground for the best experience and integration with Github.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSummary> AgentsGetAsync(
            global::G.AgentsGetCartesiaVersion cartesiaVersion,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}