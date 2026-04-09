//HintName: G.ITracesClient.DeleteTraceThreads.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete trace threads<br/>
        /// Delete trace threads
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceThreadsAsync(

            global::G.DeleteTraceThreads request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete trace threads<br/>
        /// Delete trace threads
        /// </summary>
        /// <param name="projectName">
        /// If null, project_id must be provided
        /// </param>
        /// <param name="projectId">
        /// If null, project_name must be provided
        /// </param>
        /// <param name="threadIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceThreadsAsync(
            global::System.Collections.Generic.IList<string> threadIds,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}