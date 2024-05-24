//HintName: G.ExportClient.ExportStartExportBubbleChartJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExportClient
    {
        /// <summary>
        /// StartExportBubbleChartJob.
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
        public async global::System.Threading.Tasks.Task ExportStartExportBubbleChartJobAsync(
            string token,
            string projectId,
            string title,
            global::System.Collections.Generic.IList<string> columnLabels,
            global::System.Collections.Generic.IList<string> rowLabels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> rows,
            float maxCount,
            bool colorByTotal,
            string extension,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/export/startexportbubblechartjob?projectId={projectId}&Title={title}&{string.Join("&", columnLabels.Select(static x => $"columnLabels={x}"))}&{string.Join("&", rowLabels.Select(static x => $"rowLabels={x}"))}&{string.Join("&", rows.Select(static x => $"rows={x}"))}&MaxCount={maxCount}&ColorByTotal={colorByTotal}&extension={extension}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}