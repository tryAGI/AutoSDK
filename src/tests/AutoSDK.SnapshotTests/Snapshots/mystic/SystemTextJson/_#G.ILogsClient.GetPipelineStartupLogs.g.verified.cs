//HintName: G.ILogsClient.GetPipelineStartupLogs.g.cs
#nullable enable

namespace G
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get Pipeline Startup Logs<br/>
        /// Get the logs for pipeline starting up
        /// </summary>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetPipelineStartupLogsAsync(
            string pipelineIdOrPointer,
            string? pipelineId = default,
            string? pointer = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}