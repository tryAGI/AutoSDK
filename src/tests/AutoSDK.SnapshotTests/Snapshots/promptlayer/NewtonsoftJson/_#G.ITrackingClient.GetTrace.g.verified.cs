//HintName: G.ITrackingClient.GetTrace.g.cs
#nullable enable

namespace G
{
    public partial interface ITrackingClient
    {
        /// <summary>
        /// Get Trace
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTraceResponse> GetTraceAsync(
            string traceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}