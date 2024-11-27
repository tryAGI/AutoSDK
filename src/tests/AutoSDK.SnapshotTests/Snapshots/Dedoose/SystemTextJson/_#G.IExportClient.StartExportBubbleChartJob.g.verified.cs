//HintName: G.IExportClient.StartExportBubbleChartJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// StartExportBubbleChartJob<br/>
        /// StartExportBubbleChartJob
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportBubbleChartJobAsync(
            global::G.StartExportBubbleChartJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportBubbleChartJob<br/>
        /// StartExportBubbleChartJob
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="series"></param>
        /// <param name="extension"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportBubbleChartJobAsync(
            global::System.Guid projectId,
            global::G.GridChartExportVO series,
            string extension,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}