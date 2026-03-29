//HintName: G.IToolsClient.SearchTools.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Search Tools<br/>
        /// Search tools using semantic search.<br/>
        /// Requires tool embedding to be enabled (embed_tools=True). Uses vector search,<br/>
        /// full-text search, or hybrid mode to find tools matching the query.<br/>
        /// Returns tools ranked by relevance with their search scores.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ToolSearchResult>> SearchToolsAsync(

            global::G.ToolSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Tools<br/>
        /// Search tools using semantic search.<br/>
        /// Requires tool embedding to be enabled (embed_tools=True). Uses vector search,<br/>
        /// full-text search, or hybrid mode to find tools matching the query.<br/>
        /// Returns tools ranked by relevance with their search scores.
        /// </summary>
        /// <param name="query">
        /// Text query for semantic search.
        /// </param>
        /// <param name="searchMode">
        /// Search mode: vector, fts, or hybrid.<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="toolTypes">
        /// Filter by tool types (e.g., 'custom', 'letta_core').
        /// </param>
        /// <param name="tags">
        /// Filter by tags (match any).
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ToolSearchResult>> SearchToolsAsync(
            string? query = default,
            global::G.ToolSearchRequestSearchMode? searchMode = default,
            global::System.Collections.Generic.IList<string>? toolTypes = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}