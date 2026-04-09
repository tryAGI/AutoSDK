//HintName: G.ILogsClient.PostInternalTriggerLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Search and retrieve trigger event logs<br/>
        /// Search and retrieve trigger event logs with advanced filtering capabilities including search parameters
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostInternalTriggerLogsResponse> PostInternalTriggerLogsAsync(

            global::G.PostInternalTriggerLogsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search and retrieve trigger event logs<br/>
        /// Search and retrieve trigger event logs with advanced filtering capabilities including search parameters
        /// </summary>
        /// <param name="time">
        /// Return logs from the last N time units<br/>
        /// Example: 5m
        /// </param>
        /// <param name="from">
        /// Start time for logs (epoch timestamp in milliseconds)
        /// </param>
        /// <param name="to">
        /// End time for logs (epoch timestamp in milliseconds)
        /// </param>
        /// <param name="status">
        /// Filter logs by their status level<br/>
        /// Example: success
        /// </param>
        /// <param name="search">
        /// Search term to filter logs
        /// </param>
        /// <param name="integrationId"></param>
        /// <param name="entityId"></param>
        /// <param name="userId">
        /// Filter logs by user ID
        /// </param>
        /// <param name="limit">
        /// The limit of trigger logs to return<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="searchParams">
        /// Advanced search parameters for filtering logs
        /// </param>
        /// <param name="includePayload">
        /// Whether to include payload fields in the response. Set to false for faster list views.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostInternalTriggerLogsResponse> PostInternalTriggerLogsAsync(
            global::G.PostInternalTriggerLogsRequestTime? time = default,
            double? from = default,
            double? to = default,
            global::G.PostInternalTriggerLogsRequestStatus? status = default,
            string? search = default,
            global::System.Guid? integrationId = default,
            string? entityId = default,
            string? userId = default,
            double? limit = default,
            string? cursor = default,
            global::System.Collections.Generic.IList<global::G.PostInternalTriggerLogsRequestSearchParam>? searchParams = default,
            bool? includePayload = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}