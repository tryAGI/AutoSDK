//HintName: G.ITraceClient.TraceDeleteMultiple.g.cs
#nullable enable

namespace G
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// Delete multiple traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteTraceResponse> TraceDeleteMultipleAsync(

            global::G.TraceDeleteMultipleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete multiple traces
        /// </summary>
        /// <param name="traceIds">
        /// List of trace IDs to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteTraceResponse> TraceDeleteMultipleAsync(
            global::System.Collections.Generic.IList<string> traceIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}