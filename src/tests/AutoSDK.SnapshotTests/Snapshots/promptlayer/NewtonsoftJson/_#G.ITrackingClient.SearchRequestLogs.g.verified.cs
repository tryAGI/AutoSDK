//HintName: G.ITrackingClient.SearchRequestLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ITrackingClient
    {
        /// <summary>
        /// Search Request Logs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchRequestLogsResponse> SearchRequestLogsAsync(

            global::G.SearchRequestLogsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Request Logs
        /// </summary>
        /// <param name="filterGroup">
        /// Nested filter group with AND/OR logic. Use this for complex queries.
        /// </param>
        /// <param name="q">
        /// Free-text search query. Searches across the prompt input and LLM output text using fuzzy prefix matching.
        /// </param>
        /// <param name="page">
        /// Page number for pagination. Defaults to 1.
        /// </param>
        /// <param name="perPage">
        /// Number of results per page. Defaults to 10, maximum 25.
        /// </param>
        /// <param name="sortBy">
        /// Field to sort results by.
        /// </param>
        /// <param name="sortOrder">
        /// Sort direction. Must be provided together with sort_by.
        /// </param>
        /// <param name="includePromptName">
        /// When true, includes the prompt template name in each result item. Defaults to false.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchRequestLogsResponse> SearchRequestLogsAsync(
            global::G.StructuredFilterGroup? filterGroup = default,
            string? q = default,
            int? page = default,
            int? perPage = default,
            global::G.SearchRequestLogsRequestSortBy? sortBy = default,
            global::G.SearchRequestLogsRequestSortOrder? sortOrder = default,
            bool? includePromptName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}