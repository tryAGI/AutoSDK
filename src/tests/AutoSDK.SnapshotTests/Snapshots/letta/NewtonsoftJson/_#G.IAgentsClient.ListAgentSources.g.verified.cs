//HintName: G.IAgentsClient.ListAgentSources.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agent Sources<br/>
        /// Get the sources associated with an agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// Source ID cursor for pagination. Returns sources that come before this source ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Source ID cursor for pagination. Returns sources that come after this source ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of sources to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for sources by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Source2>> ListAgentSourcesAsync(
            string agentId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListAgentSourcesOrder? order = default,
            string? orderBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}