//HintName: G.IAgentsClient.RetrieveAgent.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Retrieve Agent<br/>
        /// Get the state of the agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="includeRelationships">
        /// Specify which relational fields (e.g., 'tools', 'sources', 'memory') to include in the response. If not provided, all relationships are loaded by default. Using this can optimize performance by reducing unnecessary joins.This is a legacy parameter, and no longer supported after 1.0.0 SDK versions.
        /// </param>
        /// <param name="include">
        /// Specify which relational fields to include in the response. No relationships are included by default.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentState> RetrieveAgentAsync(
            string agentId,
            global::System.Collections.Generic.IList<string>? includeRelationships = default,
            global::System.Collections.Generic.IList<global::G.RetrieveAgentIncludeItem>? include = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}