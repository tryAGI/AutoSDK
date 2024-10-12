//HintName: G.IExportClient.ExportStartExportHierarchicalChartJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// StartExportHierarchicalChartJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="parentItems"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportStartExportHierarchicalChartJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? title = default,
            global::System.Collections.Generic.IList<global::G.ChartHierarchicalItemInfo>? parentItems = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}