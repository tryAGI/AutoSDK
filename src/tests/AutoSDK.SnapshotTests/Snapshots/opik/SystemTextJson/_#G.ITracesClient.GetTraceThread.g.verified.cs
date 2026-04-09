//HintName: G.ITracesClient.GetTraceThread.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get trace thread<br/>
        /// Get trace thread
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TraceThread> GetTraceThreadAsync(

            global::G.TraceThreadIdentifier request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get trace thread<br/>
        /// Get trace thread
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectId"></param>
        /// <param name="threadId"></param>
        /// <param name="truncate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TraceThread> GetTraceThreadAsync(
            string threadId,
            string? projectName = default,
            global::System.Guid? projectId = default,
            bool? truncate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}