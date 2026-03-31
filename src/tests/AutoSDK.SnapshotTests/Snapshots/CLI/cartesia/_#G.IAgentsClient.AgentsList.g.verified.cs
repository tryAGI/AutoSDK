//HintName: G.IAgentsClient.AgentsList.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agents<br/>
        /// Lists all agents associated with your account.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAgentsResponse> AgentsListAsync(
            global::G.AgentsListCartesiaVersion cartesiaVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}