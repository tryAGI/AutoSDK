//HintName: G.IPipelineDataSourcesClient.SyncPipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdSyncPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineDataSourcesClient
    {
        /// <summary>
        /// Sync Pipeline Data Source<br/>
        /// Run ingestion for the pipeline data source by incrementally updating the data-sink with upstream changes from data-source.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> SyncPipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdSyncPostAsync(
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,

            global::G.DataSourceSyncRequest request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync Pipeline Data Source<br/>
        /// Run ingestion for the pipeline data source by incrementally updating the data-sink with upstream changes from data-source.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> SyncPipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdSyncPostAsync(
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}