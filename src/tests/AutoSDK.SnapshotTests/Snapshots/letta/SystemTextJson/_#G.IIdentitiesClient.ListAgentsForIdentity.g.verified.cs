//HintName: G.IIdentitiesClient.ListAgentsForIdentity.g.cs
#nullable enable

namespace G
{
    public partial interface IIdentitiesClient
    {
        /// <summary>
        /// List Agents For Identity<br/>
        /// Get all agents associated with the specified identity.
        /// </summary>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// Agent ID cursor for pagination. Returns agents that come before this agent ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Agent ID cursor for pagination. Returns agents that come after this agent ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of agents to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="include">
        /// Specify which relational fields to include in the response. No relationships are included by default.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AgentState>> ListAgentsForIdentityAsync(
            string identityId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListAgentsForIdentityOrder? order = default,
            string? orderBy = default,
            global::System.Collections.Generic.IList<global::G.ListAgentsForIdentityIncludeItem>? include = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}