//HintName: G.ITraceClient.LogTrace.g.cs
#nullable enable

namespace G
{
    public partial interface ITraceClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task LogTraceAsync(

            global::G.OTELTrace request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceSpans"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task LogTraceAsync(
            global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpan> resourceSpans,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}