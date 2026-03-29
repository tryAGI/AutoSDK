//HintName: G.IPipelineFilesClient.AddFilesToPipelineApiApiV1PipelinesPipelineIdFilesPut.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// Add Files To Pipeline Api<br/>
        /// Add files to a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PipelineFile>> AddFilesToPipelineApiApiV1PipelinesPipelineIdFilesPutAsync(
            global::System.Guid pipelineId,

            global::System.Collections.Generic.IList<global::G.PipelineFileCreate> request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}