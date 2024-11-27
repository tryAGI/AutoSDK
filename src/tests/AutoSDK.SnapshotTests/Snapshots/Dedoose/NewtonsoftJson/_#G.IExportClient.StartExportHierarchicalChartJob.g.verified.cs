//HintName: G.IExportClient.StartExportHierarchicalChartJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// StartExportHierarchicalChartJob<br/>
        /// StartExportHierarchicalChartJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportHierarchicalChartJobAsync(
            global::G.StartExportHierarchicalChartJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportHierarchicalChartJob<br/>
        /// StartExportHierarchicalChartJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="exportInfo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportHierarchicalChartJobAsync(
            global::System.Guid projectId,
            global::G.ChartHierarchicalExportInfo exportInfo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}