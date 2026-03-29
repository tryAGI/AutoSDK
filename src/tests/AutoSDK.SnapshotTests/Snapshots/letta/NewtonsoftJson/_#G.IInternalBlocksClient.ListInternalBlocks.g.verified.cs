//HintName: G.IInternalBlocksClient.ListInternalBlocks.g.cs
#nullable enable

namespace G
{
    public partial interface IInternalBlocksClient
    {
        /// <summary>
        /// List Blocks
        /// </summary>
        /// <param name="label">
        /// Label to include (alphanumeric, hyphens, underscores, forward slashes)
        /// </param>
        /// <param name="templatesOnly">
        /// Whether to include only templates<br/>
        /// Default Value: false
        /// </param>
        /// <param name="name">
        /// Name filter (alphanumeric, spaces, hyphens, underscores)
        /// </param>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="identifierKeys">
        /// Search agents by identifier keys
        /// </param>
        /// <param name="projectId">
        /// Search blocks by project id
        /// </param>
        /// <param name="limit">
        /// Number of blocks to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="before">
        /// Block ID cursor for pagination. Returns blocks that come before this block ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Block ID cursor for pagination. Returns blocks that come after this block ID in the specified sort order
        /// </param>
        /// <param name="order">
        /// Sort order for blocks by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="labelSearch">
        /// Search blocks by label. If provided, returns blocks whose label matches the search query. This is a full-text search on block labels.
        /// </param>
        /// <param name="descriptionSearch">
        /// Search blocks by description. If provided, returns blocks whose description matches the search query. This is a full-text search on block descriptions.
        /// </param>
        /// <param name="valueSearch">
        /// Search blocks by value. If provided, returns blocks whose value matches the search query. This is a full-text search on block values.
        /// </param>
        /// <param name="connectedToAgentsCountGt">
        /// Filter blocks by the number of connected agents. If provided, returns blocks that have more than this number of connected agents.
        /// </param>
        /// <param name="connectedToAgentsCountLt">
        /// Filter blocks by the number of connected agents. If provided, returns blocks that have less than this number of connected agents.
        /// </param>
        /// <param name="connectedToAgentsCountEq">
        /// Filter blocks by the exact number of connected agents. If provided, returns blocks that have exactly this number of connected agents.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Block>> ListInternalBlocksAsync(
            string? label = default,
            bool? templatesOnly = default,
            string? name = default,
            string? identityId = default,
            global::System.Collections.Generic.IList<string>? identifierKeys = default,
            string? projectId = default,
            int? limit = default,
            string? before = default,
            string? after = default,
            global::G.ListInternalBlocksOrder? order = default,
            string? orderBy = default,
            string? labelSearch = default,
            string? descriptionSearch = default,
            string? valueSearch = default,
            int? connectedToAgentsCountGt = default,
            int? connectedToAgentsCountLt = default,
            global::System.Collections.Generic.IList<int>? connectedToAgentsCountEq = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}