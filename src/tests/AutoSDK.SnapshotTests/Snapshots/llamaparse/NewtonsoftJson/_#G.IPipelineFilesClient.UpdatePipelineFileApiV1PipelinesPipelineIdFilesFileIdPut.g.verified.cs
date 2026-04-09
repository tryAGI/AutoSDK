//HintName: G.IPipelineFilesClient.UpdatePipelineFileApiV1PipelinesPipelineIdFilesFileIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// Update Pipeline File<br/>
        /// Update a file for a pipeline.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelineFile> UpdatePipelineFileApiV1PipelinesPipelineIdFilesFileIdPutAsync(
            global::System.Guid fileId,
            global::System.Guid pipelineId,

            global::G.PipelineFileUpdate request,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pipeline File<br/>
        /// Update a file for a pipeline.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="customMetadata">
        /// Custom metadata for the file
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelineFile> UpdatePipelineFileApiV1PipelinesPipelineIdFilesFileIdPutAsync(
            global::System.Guid fileId,
            global::System.Guid pipelineId,
            string? session = default,
            object? customMetadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}