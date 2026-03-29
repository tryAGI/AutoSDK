//HintName: G.ITraceClient.TraceGet.g.cs
#nullable enable

namespace G
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// Get a specific trace
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TraceWithFullDetails> TraceGetAsync(
            string traceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}