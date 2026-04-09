//HintName: G.IAgentsClient.AttachIdentityToAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Attach Identity To Agent<br/>
        /// Attach an identity to an agent.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AttachIdentityToAgentAsync(
            string identityId,
            string agentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}