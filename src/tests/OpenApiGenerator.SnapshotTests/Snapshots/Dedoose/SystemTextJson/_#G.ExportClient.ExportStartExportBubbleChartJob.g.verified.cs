//HintName: G.ExportClient.ExportStartExportBubbleChartJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExportClient
    {
        partial void PrepareExportStartExportBubbleChartJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            ref string title,
            global::System.Collections.Generic.IList<string> columnLabels,
            global::System.Collections.Generic.IList<string> rowLabels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> rows,
            ref float maxCount,
            ref bool colorByTotal,
            ref string extension);
        partial void PrepareExportStartExportBubbleChartJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            string title,
            global::System.Collections.Generic.IList<string> columnLabels,
            global::System.Collections.Generic.IList<string> rowLabels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> rows,
            float maxCount,
            bool colorByTotal,
            string extension);
        partial void ProcessExportStartExportBubbleChartJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExportStartExportBubbleChartJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<object> ExportStartExportBubbleChartJobAsync(
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
            PrepareArguments(
                client: _httpClient);
            PrepareExportStartExportBubbleChartJobArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                title: ref title,
                columnLabels: columnLabels,
                rowLabels: rowLabels,
                rows: rows,
                maxCount: ref maxCount,
                colorByTotal: ref colorByTotal,
                extension: ref extension);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/export/startexportbubblechartjob?projectId={projectId}&Title={title}&{string.Join("&", columnLabels.Select(static x => $"columnLabels={x}"))}&{string.Join("&", rowLabels.Select(static x => $"rowLabels={x}"))}&{string.Join("&", rows.Select(static x => $"rows={x}"))}&MaxCount={maxCount}&ColorByTotal={colorByTotal}&extension={extension}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExportStartExportBubbleChartJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                title: title,
                columnLabels: columnLabels,
                rowLabels: rowLabels,
                rows: rows,
                maxCount: maxCount,
                colorByTotal: colorByTotal,
                extension: extension);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExportStartExportBubbleChartJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExportStartExportBubbleChartJobResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}