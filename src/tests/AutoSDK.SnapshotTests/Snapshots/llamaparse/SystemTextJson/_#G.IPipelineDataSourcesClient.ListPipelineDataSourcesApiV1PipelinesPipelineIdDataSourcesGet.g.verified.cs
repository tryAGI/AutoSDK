//HintName: G.IPipelineDataSourcesClient.ListPipelineDataSourcesApiV1PipelinesPipelineIdDataSourcesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineDataSourcesClient
    {
        /// <summary>
        /// List Pipeline Data Sources<br/>
        /// Get data sources for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PipelineDataSource>> ListPipelineDataSourcesApiV1PipelinesPipelineIdDataSourcesGetAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}