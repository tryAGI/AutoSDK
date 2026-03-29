//HintName: G.IAgentsClient.DetachIdentityFromAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Detach Identity From Agent<br/>
        /// Detach an identity from an agent.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DetachIdentityFromAgentAsync(
            string identityId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}