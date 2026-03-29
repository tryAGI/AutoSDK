//HintName: G.IAgentsClient.ListAgents.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agents<br/>
        /// Get a list of all agents.
        /// </summary>
        /// <param name="name">
        /// Name of the agent
        /// </param>
        /// <param name="tags">
        /// List of tags to filter agents by
        /// </param>
        /// <param name="matchAllTags">
        /// If True, only returns agents that match ALL given tags. Otherwise, return agents that have ANY of the passed-in tags.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="before">
        /// Cursor for pagination
        /// </param>
        /// <param name="after">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// Limit for pagination<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="queryText">
        /// Search agents by name
        /// </param>
        /// <param name="projectId">
        /// Search agents by project ID - this will default to your default project on cloud
        /// </param>
        /// <param name="templateId">
        /// Search agents by template ID
        /// </param>
        /// <param name="baseTemplateId">
        /// Search agents by base template ID
        /// </param>
        /// <param name="identityId">
        /// Search agents by identity ID
        /// </param>
        /// <param name="identifierKeys">
        /// Search agents by identifier keys
        /// </param>
        /// <param name="includeRelationships">
        /// Specify which relational fields (e.g., 'tools', 'sources', 'memory') to include in the response. If not provided, all relationships are loaded by default. Using this can optimize performance by reducing unnecessary joins.This is a legacy parameter, and no longer supported after 1.0.0 SDK versions.
        /// </param>
        /// <param name="include">
        /// Specify which relational fields to include in the response. No relationships are included by default.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="order">
        /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="ascending">
        /// Whether to sort agents oldest to newest (True) or newest to oldest (False, default)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by. Options: 'created_at' (default), 'last_run_completion'<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="lastStopReason">
        /// Filter agents by their last stop reason.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AgentState>> ListAgentsAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? matchAllTags = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            string? queryText = default,
            string? projectId = default,
            string? templateId = default,
            string? baseTemplateId = default,
            string? identityId = default,
            global::System.Collections.Generic.IList<string>? identifierKeys = default,
            global::System.Collections.Generic.IList<string>? includeRelationships = default,
            global::System.Collections.Generic.IList<global::G.ListAgentsIncludeItem>? include = default,
            global::G.ListAgentsOrder? order = default,
            global::G.ListAgentsOrderBy? orderBy = default,
            bool? ascending = default,
            string? sortBy = default,
            global::G.StopReasonType? lastStopReason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}