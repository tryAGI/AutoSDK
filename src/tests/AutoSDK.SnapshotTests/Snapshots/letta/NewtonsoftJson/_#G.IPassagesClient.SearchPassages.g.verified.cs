//HintName: G.IPassagesClient.SearchPassages.g.cs
#nullable enable

namespace G
{
    public partial interface IPassagesClient
    {
        /// <summary>
        /// Search Passages<br/>
        /// Search passages across the organization with optional agent and archive filtering.<br/>
        /// Returns passages with relevance scores.<br/>
        /// This endpoint supports semantic search through passages:<br/>
        /// - If neither agent_id nor archive_id is provided, searches ALL passages in the organization<br/>
        /// - If agent_id is provided, searches passages across all archives attached to that agent<br/>
        /// - If archive_id is provided, searches passages within that specific archive<br/>
        /// - If both are provided, agent_id takes precedence
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PassageSearchResult>> SearchPassagesAsync(

            global::G.PassageSearchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Passages<br/>
        /// Search passages across the organization with optional agent and archive filtering.<br/>
        /// Returns passages with relevance scores.<br/>
        /// This endpoint supports semantic search through passages:<br/>
        /// - If neither agent_id nor archive_id is provided, searches ALL passages in the organization<br/>
        /// - If agent_id is provided, searches passages across all archives attached to that agent<br/>
        /// - If archive_id is provided, searches passages within that specific archive<br/>
        /// - If both are provided, agent_id takes precedence
        /// </summary>
        /// <param name="query">
        /// Text query for semantic search
        /// </param>
        /// <param name="agentId">
        /// Filter passages by agent ID
        /// </param>
        /// <param name="archiveId">
        /// Filter passages by archive ID
        /// </param>
        /// <param name="tags">
        /// Optional list of tags to filter search results
        /// </param>
        /// <param name="tagMatchMode">
        /// How to match tags - 'any' to match passages with any of the tags, 'all' to match only passages with all tags<br/>
        /// Default Value: any
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="startDate">
        /// Filter results to passages created after this datetime
        /// </param>
        /// <param name="endDate">
        /// Filter results to passages created before this datetime
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PassageSearchResult>> SearchPassagesAsync(
            string? query = default,
            string? agentId = default,
            string? archiveId = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.PassageSearchRequestTagMatchMode? tagMatchMode = default,
            int? limit = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}