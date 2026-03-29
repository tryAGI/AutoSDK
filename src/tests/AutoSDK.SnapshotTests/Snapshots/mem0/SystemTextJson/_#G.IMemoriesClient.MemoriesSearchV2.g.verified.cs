//HintName: G.IMemoriesClient.MemoriesSearchV2.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Search memories based on a query and filters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesSearchV2ResponseItem>> MemoriesSearchV2Async(

            global::G.MemorySearchInputV2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search memories based on a query and filters.
        /// </summary>
        /// <param name="query">
        /// The query to search for in the memory.
        /// </param>
        /// <param name="version">
        /// The version of the memory to use. This should always be v2.<br/>
        /// Default Value: v2
        /// </param>
        /// <param name="filters">
        /// A dictionary of filters to apply to the search. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at, categories, keywords. Supports logical operators (AND, OR) and comparison operators (in, gte, lte, gt, lt, ne, contains, icontains). For categories field, use 'contains' for partial matching (e.g., {"categories": {"contains": "finance"}}) or 'in' for exact matching (e.g., {"categories": {"in": ["personal_information"]}}).
        /// </param>
        /// <param name="topK">
        /// The number of top results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="fields">
        /// A list of field names to include in the response. If not provided, all fields will be returned.
        /// </param>
        /// <param name="rerank">
        /// Whether to rerank the memories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keywordSearch">
        /// Whether to search for memories based on keywords.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filterMemories">
        /// Whether to filter the memories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="threshold">
        /// The minimum similarity threshold for returned results.<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with the memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with the memory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesSearchV2ResponseItem>> MemoriesSearchV2Async(
            string query,
            global::G.MemorySearchInputV2Filters filters,
            string? version = default,
            int? topK = default,
            global::System.Collections.Generic.IList<string>? fields = default,
            bool? rerank = default,
            bool? keywordSearch = default,
            bool? filterMemories = default,
            double? threshold = default,
            string? orgId = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}