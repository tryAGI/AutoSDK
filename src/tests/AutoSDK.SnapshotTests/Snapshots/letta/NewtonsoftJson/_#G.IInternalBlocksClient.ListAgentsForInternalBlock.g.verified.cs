//HintName: G.IInternalBlocksClient.ListAgentsForInternalBlock.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IInternalBlocksClient
    {
        /// <summary>
        /// List Agents For Block<br/>
        /// Retrieves all agents associated with the specified block.<br/>
        /// Raises a 404 if the block does not exist.
        /// </summary>
        /// <param name="blockId">
        /// The ID of the block in the format 'block-&lt;uuid4&gt;'
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
        /// <param name="includeRelationships">
        /// Specify which relational fields (e.g., 'tools', 'sources', 'memory') to include in the response. If not provided, all relationships are loaded by default. Using this can optimize performance by reducing unnecessary joins.This is a legacy parameter, and no longer supported after 1.0.0 SDK versions.
        /// </param>
        /// <param name="include">
        /// Specify which relational fields to include in the response. No relationships are included by default.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AgentState>> ListAgentsForInternalBlockAsync(
            string blockId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListAgentsForInternalBlockOrder? order = default,
            string? orderBy = default,
            global::System.Collections.Generic.IList<string>? includeRelationships = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}