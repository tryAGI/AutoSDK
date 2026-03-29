//HintName: G.ISessionsClient.AnnotateSessions.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Create session annotations
        /// </summary>
        /// <param name="sync">
        /// If true, fulfill request synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotateSessionsResponseBody> AnnotateSessionsAsync(

            global::G.AnnotateSessionsRequestBody request,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create session annotations
        /// </summary>
        /// <param name="sync">
        /// If true, fulfill request synchronously.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnnotateSessionsResponseBody> AnnotateSessionsAsync(
            global::System.Collections.Generic.IList<global::G.SessionAnnotationData> data,
            bool? sync = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}