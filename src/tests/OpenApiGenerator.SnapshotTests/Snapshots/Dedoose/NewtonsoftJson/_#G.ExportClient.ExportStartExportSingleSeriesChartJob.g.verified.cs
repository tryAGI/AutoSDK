//HintName: G.ExportClient.ExportStartExportSingleSeriesChartJob.g.cs
using System.Linq;

#nullable enable

namespace G
{
    public partial class ExportClient
    {
        partial void PrepareExportStartExportSingleSeriesChartJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string token,
            ref string projectId,
            global::System.Collections.Generic.IList<global::G.ChartExportInfo> exportInfo);
        partial void PrepareExportStartExportSingleSeriesChartJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string token,
            string projectId,
            global::System.Collections.Generic.IList<global::G.ChartExportInfo> exportInfo);
        partial void ProcessExportStartExportSingleSeriesChartJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExportStartExportSingleSeriesChartJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// StartExportSingleSeriesChartJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="exportInfo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> ExportStartExportSingleSeriesChartJobAsync(
            string token,
            string projectId,
            global::System.Collections.Generic.IList<global::G.ChartExportInfo> exportInfo,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExportStartExportSingleSeriesChartJobArguments(
                httpClient: _httpClient,
                token: ref token,
                projectId: ref projectId,
                exportInfo: exportInfo);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/export/startexportsingleserieschartjob?projectId={projectId}&{string.Join("&", exportInfo.Select(static x => $"exportInfo={x}"))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExportStartExportSingleSeriesChartJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                projectId: projectId,
                exportInfo: exportInfo);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessExportStartExportSingleSeriesChartJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExportStartExportSingleSeriesChartJobResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<object?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}