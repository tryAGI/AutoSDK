//HintName: G.IRunnersClient.ReportJobResult.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Report local runner job result<br/>
        /// Report local runner job completion or failure
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReportJobResultAsync(
            global::System.Guid jobId,

            global::G.LocalRunnerJobResultRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Report local runner job result<br/>
        /// Report local runner job completion or failure
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
        /// <param name="traceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReportJobResultAsync(
            global::System.Guid jobId,
            global::G.LocalRunnerJobResultRequestStatus status,
            global::G.JsonNode? result = default,
            string? error = default,
            global::System.Guid? traceId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}