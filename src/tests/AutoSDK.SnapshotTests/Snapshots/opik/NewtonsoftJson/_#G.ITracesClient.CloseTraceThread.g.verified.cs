//HintName: G.ITracesClient.CloseTraceThread.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Close trace thread(s)<br/>
        /// Close one or multiple trace threads. Supports both single thread_id and multiple thread_ids for batch operations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CloseTraceThreadAsync(

            global::G.TraceThreadBatchIdentifier request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Close trace thread(s)<br/>
        /// Close one or multiple trace threads. Supports both single thread_id and multiple thread_ids for batch operations.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="threadId"></param>
        /// <param name="threadIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CloseTraceThreadAsync(
            string? projectName = default,
            global::System.Guid? projectId = default,
            string? threadId = default,
            global::System.Collections.Generic.IList<string>? threadIds = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}