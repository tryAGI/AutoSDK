//HintName: G.ITasksClient.TaskStatusPollV1StatusPollTaskIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Task Status Poll
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="wait">
        /// Number of seconds to wait for a completed status.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TaskStatusResponse> TaskStatusPollV1StatusPollTaskIdGetAsync(
            string taskId,
            double? wait = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}