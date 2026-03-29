//HintName: G.IAgentsClient.ListFilesForAgent.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Files For Agent<br/>
        /// Get the files attached to an agent with their open/closed status.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// File ID cursor for pagination. Returns files that come before this file ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// File ID cursor for pagination. Returns files that come after this file ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of files to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for files by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response (deprecated, use before/after)
        /// </param>
        /// <param name="isOpen">
        /// Filter by open status (true for open files, false for closed files)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedAgentFiles> ListFilesForAgentAsync(
            string agentId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListFilesForAgentOrder? order = default,
            string? orderBy = default,
            string? cursor = default,
            bool? isOpen = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}