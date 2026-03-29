//HintName: G.IPipelinesClient.GetPipelineStatusApiV1PipelinesPipelineIdStatusGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get Pipeline Status<br/>
        /// Get the ingestion status of a managed pipeline.<br/>
        /// Returns document counts, sync progress, and the last<br/>
        /// effective timestamp. Only available for managed pipelines.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="fullDetails"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ManagedIngestionStatusResponse> GetPipelineStatusApiV1PipelinesPipelineIdStatusGetAsync(
            global::System.Guid pipelineId,
            bool? fullDetails = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}