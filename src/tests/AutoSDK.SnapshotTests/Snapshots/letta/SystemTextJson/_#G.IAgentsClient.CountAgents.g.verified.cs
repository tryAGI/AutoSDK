//HintName: G.IAgentsClient.CountAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Count Agents<br/>
        /// Get the total number of agents with optional filtering.<br/>
        /// Supports the same filters as list_agents for consistent querying.
        /// </summary>
        /// <param name="name">
        /// Name of the agent
        /// </param>
        /// <param name="tags">
        /// List of tags to filter agents by
        /// </param>
        /// <param name="matchAllTags">
        /// If True, only counts agents that match ALL given tags. Otherwise, counts agents that have ANY of the passed-in tags.<br/>
        /// Default Value: false
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
        /// <param name="lastStopReason">
        /// Filter agents by their last stop reason.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> CountAgentsAsync(
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? matchAllTags = default,
            string? queryText = default,
            string? projectId = default,
            string? templateId = default,
            string? baseTemplateId = default,
            string? identityId = default,
            global::System.Collections.Generic.IList<string>? identifierKeys = default,
            global::G.StopReasonType? lastStopReason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}