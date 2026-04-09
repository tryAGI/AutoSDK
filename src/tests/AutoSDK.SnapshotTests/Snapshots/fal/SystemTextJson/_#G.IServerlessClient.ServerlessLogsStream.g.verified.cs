//HintName: G.IServerlessClient.ServerlessLogsStream.g.cs
#nullable enable

namespace G
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Logs stream (SSE)<br/>
        /// Streams live logs that match the provided filters using Server-Sent Events.
        /// </summary>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="appId">
        /// Filter by app IDs<br/>
        /// Example: [my-app]
        /// </param>
        /// <param name="revision">
        /// Filter by revision<br/>
        /// Example: rev_abc123
        /// </param>
        /// <param name="runSource">
        /// Filter by run source<br/>
        /// Example: grpc-run
        /// </param>
        /// <param name="traceback">
        /// Include tracebacks<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="search">
        /// Free-text search<br/>
        /// Example: error
        /// </param>
        /// <param name="level">
        /// Minimum log level<br/>
        /// Example: error
        /// </param>
        /// <param name="jobId">
        /// Filter by job id<br/>
        /// Example: job_123
        /// </param>
        /// <param name="requestId">
        /// Filter by request id<br/>
        /// Example: req_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<string> ServerlessLogsStreamAsync(

            global::System.Collections.Generic.IList<global::G.ServerlessLogsStreamRequestItem> request,
            global::G.AnyOf<global::System.DateTime?, string>? start = default,
            global::G.AnyOf<global::System.DateTime?, string>? end = default,
            global::System.Collections.Generic.IList<string>? appId = default,
            string? revision = default,
            global::G.ServerlessLogsStreamRunSource? runSource = default,
            bool? traceback = default,
            string? search = default,
            string? level = default,
            string? jobId = default,
            string? requestId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}