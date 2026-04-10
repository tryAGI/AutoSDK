//HintName: G.ITracesClient.DeleteTrace.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete a trace by identifier<br/>
        /// Delete an entire trace by its identifier. The identifier can be either:<br/>
        /// 1. A Relay node ID (base64-encoded)<br/>
        /// 2. An OpenTelemetry trace_id (hex string)<br/>
        /// This will permanently remove all spans in the trace and their associated data.
        /// </summary>
        /// <param name="traceIdentifier">
        /// The trace identifier: either a relay GlobalID or OpenTelemetry trace_id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceAsync(
            string traceIdentifier,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}