//HintName: G.ExportClient.ExportStartGridChartExportJob.g.cs

#nullable enable

namespace G
{
    public partial class ExportClient
    {
        partial void PrepareExportStartGridChartExportJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? projectId,
            ref string? title,
            global::System.Collections.Generic.IList<string>? columnLabels,
            global::System.Collections.Generic.IList<string>? rowLabels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? rows,
            ref float? maxCount,
            ref bool? colorByTotal,
            ref string? extension);
        partial void PrepareExportStartGridChartExportJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? projectId,
            string? title,
            global::System.Collections.Generic.IList<string>? columnLabels,
            global::System.Collections.Generic.IList<string>? rowLabels,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? rows,
            float? maxCount,
            bool? colorByTotal,
            string? extension);
        partial void ProcessExportStartGridChartExportJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessExportStartGridChartExportJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.ExportStartGridChartExportJobResponse> ExportStartGridChartExportJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? title = default,
            global::System.Collections.Generic.IList<string>? columnLabels = default,
            global::System.Collections.Generic.IList<string>? rowLabels = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? rows = default,
            float? maxCount = default,
            bool? colorByTotal = default,
            string? extension = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareExportStartGridChartExportJobArguments(
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

            if (token != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("token", token.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/export/startgridchartexportjob",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("projectId", projectId?.ToString()) 
                .AddOptionalParameter("Title", title) 
                .AddOptionalParameter("ColumnLabels", columnLabels, delimiter: ",", explode: true) 
                .AddOptionalParameter("RowLabels", rowLabels, delimiter: ",", explode: true) 
                .AddOptionalParameter("MaxCount", maxCount?.ToString()) 
                .AddOptionalParameter("ColorByTotal", colorByTotal?.ToString()) 
                .AddOptionalParameter("extension", extension) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareExportStartGridChartExportJobRequest(
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
            ProcessExportStartGridChartExportJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessExportStartGridChartExportJobResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ExportStartGridChartExportJobResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}