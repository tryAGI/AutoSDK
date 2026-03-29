//HintName: G.IMemoriesClient.MemoriesListV2.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Get all memories.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesListV2ResponseItem>> MemoriesListV2Async(

            global::G.MemoryGetInputV2 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all memories.
        /// </summary>
        /// <param name="filters">
        /// A dictionary of filters to apply to retrieve memories. Available fields are: user_id, agent_id, app_id, run_id, created_at, updated_at, categories, keywords. Supports logical operators (AND, OR) and comparison operators (in, gte, lte, gt, lt, ne, contains, icontains, *). For categories field, use 'contains' for partial matching (e.g., {"categories": {"contains": "finance"}}) or 'in' for exact matching (e.g., {"categories": {"in": ["personal_information"]}}).
        /// </param>
        /// <param name="fields">
        /// A list of field names to include in the response. If not provided, all fields will be returned.
        /// </param>
        /// <param name="page">
        /// Page number for pagination. Default: 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page. Default: 100<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with the memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with the memory.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesListV2ResponseItem>> MemoriesListV2Async(
            global::G.MemoryGetInputV2Filters filters,
            global::System.Collections.Generic.IList<string>? fields = default,
            int? page = default,
            int? pageSize = default,
            string? orgId = default,
            string? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}