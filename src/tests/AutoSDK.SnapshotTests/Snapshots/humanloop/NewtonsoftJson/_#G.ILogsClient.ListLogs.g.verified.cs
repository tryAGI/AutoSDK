//HintName: G.ILogsClient.ListLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// List Logs
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="fileId"></param>
        /// <param name="versionId"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedLogResponse> ListLogsAsync(
            int? page = default,
            int? size = default,
            string? fileId = default,
            string? versionId = default,
            string? search = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}