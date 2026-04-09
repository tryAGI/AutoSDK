//HintName: G.IPipelineFilesClient.GetPipelineFileStatusApiV1PipelinesPipelineIdFilesFileIdStatusGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// Get Pipeline File Status<br/>
        /// Get status of a file for a pipeline.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ManagedIngestionStatusResponse> GetPipelineFileStatusApiV1PipelinesPipelineIdFilesFileIdStatusGetAsync(
            global::System.Guid fileId,
            global::System.Guid pipelineId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}