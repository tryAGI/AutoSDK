//HintName: G.IAgentsClient.ListFoldersForAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Folders For Agent<br/>
        /// Get the folders associated with an agent.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Source2>> ListFoldersForAgentAsync(
            string agentId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListFoldersForAgentOrder? order = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}