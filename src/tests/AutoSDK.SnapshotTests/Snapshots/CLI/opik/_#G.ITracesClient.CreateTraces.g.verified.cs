//HintName: G.ITracesClient.CreateTraces.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Create traces<br/>
        /// Create traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateTracesAsync(

            global::G.TraceBatchWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create traces<br/>
        /// Create traces
        /// </summary>
        /// <param name="traces"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateTracesAsync(
            global::System.Collections.Generic.IList<global::G.TraceWrite> traces,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}