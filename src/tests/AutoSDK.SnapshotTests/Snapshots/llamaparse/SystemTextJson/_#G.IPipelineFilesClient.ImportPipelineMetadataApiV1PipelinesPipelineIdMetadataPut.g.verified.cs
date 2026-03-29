//HintName: G.IPipelineFilesClient.ImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// Import Pipeline Metadata<br/>
        /// Import metadata for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> ImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPutAsync(
            global::System.Guid pipelineId,

            global::G.BodyImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPut request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import Pipeline Metadata<br/>
        /// Import metadata for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="uploadFile"></param>
        /// <param name="uploadFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> ImportPipelineMetadataApiV1PipelinesPipelineIdMetadataPutAsync(
            global::System.Guid pipelineId,
            byte[] uploadFile,
            string uploadFilename,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}