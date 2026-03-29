//HintName: G.IAgentsClient.AgentsGetAgentVariables.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Retrieve Memory Variables<br/>
        /// Get the variables associated with an agent
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentsGetAgentVariablesResponse> AgentsGetAgentVariablesAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}