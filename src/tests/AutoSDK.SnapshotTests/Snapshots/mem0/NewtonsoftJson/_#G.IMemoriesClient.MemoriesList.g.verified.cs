//HintName: G.IMemoriesClient.MemoriesList.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Get all memories.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="appId"></param>
        /// <param name="runId"></param>
        /// <param name="metadata"></param>
        /// <param name="categories"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="fields"></param>
        /// <param name="keywords"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesListResponseItem>> MemoriesListAsync(
            string? userId = default,
            string? agentId = default,
            string? appId = default,
            string? runId = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? categories = default,
            string? orgId = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? fields = default,
            string? keywords = default,
            int? page = default,
            int? pageSize = default,
            string? startDate = default,
            string? endDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}