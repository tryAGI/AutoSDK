//HintName: G.IStreamingApiClient.StreamingTask.g.cs
#nullable enable

namespace G
{
    public partial interface IStreamingApiClient
    {
        /// <summary>
        /// streaming.task<br/>
        /// streaming.task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task StreamingTaskAsync(

            global::G.StreamingTaskRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// streaming.task<br/>
        /// streaming.task
        /// </summary>
        /// <param name="sessionId">
        /// Example: &lt;session_id&gt;
        /// </param>
        /// <param name="text">
        /// Example: Hey, there!
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StreamingTaskAsync(
            string? sessionId = default,
            string? text = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}