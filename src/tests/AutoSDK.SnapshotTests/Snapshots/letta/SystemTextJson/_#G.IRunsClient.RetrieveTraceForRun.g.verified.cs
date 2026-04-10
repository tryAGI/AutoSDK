//HintName: G.IRunsClient.RetrieveTraceForRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve Trace For Run<br/>
        /// Retrieve OTEL trace spans for a run.<br/>
        /// Returns a filtered set of spans relevant for observability:<br/>
        /// - agent_step: Individual agent reasoning steps<br/>
        /// - tool executions: Tool call spans<br/>
        /// - Root span: The top-level request span<br/>
        /// - time_to_first_token: TTFT measurement span<br/>
        /// Requires ClickHouse to be configured for trace storage.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="limit">
        /// Maximum number of spans to return<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<object>> RetrieveTraceForRunAsync(
            string runId,
            int? limit = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}