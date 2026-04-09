//HintName: G.IAgentsClient.SearchArchivalMemory.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Search Archival Memory<br/>
        /// Search archival memory using semantic (embedding-based) search with optional temporal filtering.<br/>
        /// This endpoint allows manual triggering of archival memory searches, enabling users to query<br/>
        /// an agent's archival memory store directly via the API. The search uses the same functionality<br/>
        /// as the agent's archival_memory_search tool but is accessible for external API usage.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="query">
        /// String to search for using semantic similarity
        /// </param>
        /// <param name="tags">
        /// Optional list of tags to filter search results
        /// </param>
        /// <param name="tagMatchMode">
        /// How to match tags - 'any' to match passages with any of the tags, 'all' to match only passages with all tags<br/>
        /// Default Value: any
        /// </param>
        /// <param name="topK">
        /// Maximum number of results to return. Uses system default if not specified
        /// </param>
        /// <param name="startDatetime">
        /// Filter results to passages created after this datetime
        /// </param>
        /// <param name="endDatetime">
        /// Filter results to passages created before this datetime
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ArchivalMemorySearchResponse> SearchArchivalMemoryAsync(
            string agentId,
            string query,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.SearchArchivalMemoryTagMatchMode? tagMatchMode = default,
            int? topK = default,
            global::System.DateTime? startDatetime = default,
            global::System.DateTime? endDatetime = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}