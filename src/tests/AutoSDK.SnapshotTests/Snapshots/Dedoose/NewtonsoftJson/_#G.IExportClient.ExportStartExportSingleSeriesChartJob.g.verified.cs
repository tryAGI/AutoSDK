//HintName: G.IExportClient.ExportStartExportSingleSeriesChartJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// StartExportSingleSeriesChartJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="exportInfo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportStartExportSingleSeriesChartJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::G.ChartExportInfo>? exportInfo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}