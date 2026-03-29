//HintName: G.IBlocksClient.CountBlocks.g.cs
#nullable enable

namespace G
{
    public partial interface IBlocksClient
    {
        /// <summary>
        /// Count Blocks<br/>
        /// Count all blocks with optional filtering.<br/>
        /// Supports the same filters as list_blocks for consistent querying.
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
        /// <param name="tags">
        /// List of tags to filter blocks by
        /// </param>
        /// <param name="matchAllTags">
        /// If True, only counts blocks that match ALL given tags. Otherwise, counts blocks that have ANY of the passed-in tags.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId">
        /// Search blocks by project id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> CountBlocksAsync(
            string? label = default,
            bool? templatesOnly = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? matchAllTags = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}