//HintName: G.IPipelinesClient.GetPipelineApiV1PipelinesPipelineIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get Pipeline<br/>
        /// Get a pipeline by ID.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> GetPipelineApiV1PipelinesPipelineIdGetAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}