//HintName: G.IRunnersClient.CreateJob.g.cs
#nullable enable

namespace G
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Create local runner job<br/>
        /// Create a local runner job and enqueue it for execution
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateJobAsync(

            global::G.CreateLocalRunnerJobRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create local runner job<br/>
        /// Create a local runner job and enqueue it for execution
        /// </summary>
        /// <param name="agentName"></param>
        /// <param name="inputs"></param>
        /// <param name="projectId"></param>
        /// <param name="maskId"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateJobAsync(
            string agentName,
            global::System.Guid projectId,
            global::G.JsonNode? inputs = default,
            global::System.Guid? maskId = default,
            global::G.LocalRunnerJobMetadata? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}