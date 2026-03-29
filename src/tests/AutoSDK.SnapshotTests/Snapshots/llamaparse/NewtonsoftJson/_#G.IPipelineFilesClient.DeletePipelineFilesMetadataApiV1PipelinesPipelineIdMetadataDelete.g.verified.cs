//HintName: G.IPipelineFilesClient.DeletePipelineFilesMetadataApiV1PipelinesPipelineIdMetadataDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// Delete Pipeline Files Metadata<br/>
        /// Delete metadata for all files in a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePipelineFilesMetadataApiV1PipelinesPipelineIdMetadataDeleteAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}