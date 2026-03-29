//HintName: G.ICallsClient.TraceUsageTraceUsagePost.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Trace Usage<br/>
        /// Compute per-call usage for a trace, with descendant rollup.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TraceUsageRes> TraceUsageTraceUsagePostAsync(

            global::G.TraceUsageReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trace Usage<br/>
        /// Compute per-call usage for a trace, with descendant rollup.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter">
        /// Filter to select calls. Typically use trace_ids to get all calls in a trace.
        /// </param>
        /// <param name="query">
        /// Additional query conditions for filtering calls.
        /// </param>
        /// <param name="includeCosts">
        /// If true, include cost calculations in the usage.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Maximum number of calls to process. Acts as a safety limit to prevent unbounded memory usage.<br/>
        /// Default Value: 10000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TraceUsageRes> TraceUsageTraceUsagePostAsync(
            string projectId,
            global::G.CallsFilter? filter = default,
            global::G.Query? query = default,
            bool? includeCosts = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}