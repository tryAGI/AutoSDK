//HintName: G.IFoldersClient.ListAgentsForFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// List Agents For Folder<br/>
        /// Get all agent IDs that have the specified folder attached.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> ListAgentsForFolderAsync(
            string folderId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListAgentsForFolderOrder? order = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}