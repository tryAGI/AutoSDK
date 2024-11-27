//HintName: G.IExportClient.StartGridChartExportJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// StartGridChartExportJob<br/>
        /// StartGridChartExportJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartGridChartExportJobAsync(
            global::G.StartGridChartExportJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartGridChartExportJob<br/>
        /// StartGridChartExportJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="export"></param>
        /// <param name="extension"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartGridChartExportJobAsync(
            global::System.Guid projectId,
            global::G.GridChartExportVO export,
            string extension,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}