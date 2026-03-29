//HintName: G.IPipelineDataSourcesClient.AddDataSourcesToPipelineApiV1PipelinesPipelineIdDataSourcesPut.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineDataSourcesClient
    {
        /// <summary>
        /// Add Data Sources To Pipeline<br/>
        /// Add data sources to a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PipelineDataSource>> AddDataSourcesToPipelineApiV1PipelinesPipelineIdDataSourcesPutAsync(
            global::System.Guid pipelineId,

            global::System.Collections.Generic.IList<global::G.PipelineDataSourceCreate> request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}