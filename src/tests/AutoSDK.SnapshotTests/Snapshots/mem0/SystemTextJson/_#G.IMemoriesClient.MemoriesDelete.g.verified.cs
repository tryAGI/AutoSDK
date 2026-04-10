//HintName: G.IMemoriesClient.MemoriesDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// Delete memories by filter. At least one filter is required — previously omitting all filters silently deleted everything; now it returns a validation error.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="appId"></param>
        /// <param name="runId"></param>
        /// <param name="metadata"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MemoriesDeleteResponse> MemoriesDeleteAsync(
            string? userId = default,
            string? agentId = default,
            string? appId = default,
            string? runId = default,
            object? metadata = default,
            string? orgId = default,
            string? projectId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}