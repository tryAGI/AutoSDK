//HintName: G.IPipelinesClient.CancelPipelineSyncApiV1PipelinesPipelineIdSyncCancelPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Cancel Pipeline Sync<br/>
        /// Cancel all running sync jobs for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> CancelPipelineSyncApiV1PipelinesPipelineIdSyncCancelPostAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}