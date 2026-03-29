//HintName: G.IAgentsClient.ListToolsForAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Tools For Agent<br/>
        /// Get tools from an existing agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// Tool ID cursor for pagination. Returns tools that come before this tool ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Tool ID cursor for pagination. Returns tools that come after this tool ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of tools to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="order">
        /// Sort order for tools by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Tool>> ListToolsForAgentAsync(
            string agentId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListToolsForAgentOrder? order = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}