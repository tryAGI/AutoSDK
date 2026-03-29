//HintName: G.IPipelineFilesClient.DeletePipelineFileApiV1PipelinesPipelineIdFilesFileIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// Delete Pipeline File<br/>
        /// Delete a file from a pipeline.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePipelineFileApiV1PipelinesPipelineIdFilesFileIdDeleteAsync(
            global::System.Guid fileId,
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}