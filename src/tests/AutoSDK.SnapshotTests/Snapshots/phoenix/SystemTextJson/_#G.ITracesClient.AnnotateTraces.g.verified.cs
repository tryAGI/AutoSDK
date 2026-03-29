//HintName: G.ITracesClient.AnnotateTraces.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Create trace annotations
        /// </summary>
        /// <param name="sync">
        /// If true, fulfill request synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotateTracesResponseBody> AnnotateTracesAsync(

            global::G.AnnotateTracesRequestBody request,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create trace annotations
        /// </summary>
        /// <param name="sync">
        /// If true, fulfill request synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="data">
        /// The trace annotations to be upserted
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotateTracesResponseBody> AnnotateTracesAsync(
            global::System.Collections.Generic.IList<global::G.TraceAnnotationData> data,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}