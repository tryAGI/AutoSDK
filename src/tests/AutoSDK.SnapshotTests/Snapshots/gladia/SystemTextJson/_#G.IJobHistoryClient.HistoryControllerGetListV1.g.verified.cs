//HintName: G.IJobHistoryClient.HistoryControllerGetListV1.g.cs
#nullable enable

namespace G
{
    public partial interface IJobHistoryClient
    {
        /// <summary>
        /// Get the history of all your jobs
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="date">
        /// Example: 2026-03-28
        /// </param>
        /// <param name="beforeDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="afterDate">
        /// Example: 2024-01-01T00:00:00.000Z
        /// </param>
        /// <param name="status">
        /// Example: [done]
        /// </param>
        /// <param name="customMetadata">
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="kind">
        /// Example: [pre-recorded]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListHistoryResponse> HistoryControllerGetListV1Async(
            int? offset = default,
            int? limit = default,
            global::System.DateTime? date = default,
            global::System.DateTime? beforeDate = default,
            global::System.DateTime? afterDate = default,
            global::System.Collections.Generic.IList<global::G.HistoryControllerGetListV1Statu>? status = default,
            object? customMetadata = default,
            global::System.Collections.Generic.IList<global::G.HistoryControllerGetListV1KindItem>? kind = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}