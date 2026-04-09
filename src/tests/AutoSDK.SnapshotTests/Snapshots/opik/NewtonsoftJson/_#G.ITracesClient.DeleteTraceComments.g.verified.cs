//HintName: G.ITracesClient.DeleteTraceComments.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete trace comments<br/>
        /// Delete trace comments
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceCommentsAsync(

            global::G.BatchDelete request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete trace comments<br/>
        /// Delete trace comments
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceCommentsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}