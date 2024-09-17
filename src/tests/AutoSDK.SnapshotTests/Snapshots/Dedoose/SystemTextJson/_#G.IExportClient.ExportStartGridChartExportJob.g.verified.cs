//HintName: G.IExportClient.ExportStartGridChartExportJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// StartGridChartExportJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="title"></param>
        /// <param name="columnLabels"></param>
        /// <param name="rowLabels"></param>
        /// <param name="rows"></param>
        /// <param name="maxCount"></param>
        /// <param name="colorByTotal"></param>
        /// <param name="extension"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExportStartGridChartExportJobResponse> ExportStartGridChartExportJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? title = default,
            global::System.Collections.Generic.IList<string>? columnLabels = default,
            global::System.Collections.Generic.IList<string>? rowLabels = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? rows = default,
            float? maxCount = default,
            bool? colorByTotal = default,
            string? extension = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}