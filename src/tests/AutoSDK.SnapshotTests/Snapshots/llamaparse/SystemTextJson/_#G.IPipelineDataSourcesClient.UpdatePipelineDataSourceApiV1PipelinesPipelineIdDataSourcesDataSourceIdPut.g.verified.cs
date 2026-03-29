//HintName: G.IPipelineDataSourcesClient.UpdatePipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineDataSourcesClient
    {
        /// <summary>
        /// Update Pipeline Data Source<br/>
        /// Update the configuration of a data source in a pipeline.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelineDataSource> UpdatePipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdPutAsync(
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,

            global::G.PipelineDataSourceUpdate request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pipeline Data Source<br/>
        /// Update the configuration of a data source in a pipeline.
        /// </summary>
        /// <param name="dataSourceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="syncInterval">
        /// The interval at which the data source should be synced.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelineDataSource> UpdatePipelineDataSourceApiV1PipelinesPipelineIdDataSourcesDataSourceIdPutAsync(
            global::System.Guid dataSourceId,
            global::System.Guid pipelineId,
            string? session = default,
            double? syncInterval = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}