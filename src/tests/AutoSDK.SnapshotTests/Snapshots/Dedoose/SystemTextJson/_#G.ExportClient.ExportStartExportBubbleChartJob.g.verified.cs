﻿//HintName: G.ExportClient.ExportStartExportBubbleChartJob.g.cs

#nullable enable

namespace G
{
    public partial class ExportClient
    {
        partial void PrepareExportStartExportBubbleChartJobArguments(
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
        partial void PrepareExportStartExportBubbleChartJobRequest(
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
        public async global::System.Threading.Tasks.Task<string> ExportStartExportBubbleChartJobAsync(
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
                client: HttpClient);
            PrepareExportStartExportBubbleChartJobArguments(
                httpClient: HttpClient,
                token: ref token,
                projectId: ref projectId,
                title: ref title,
                columnLabels: columnLabels,
                rowLabels: rowLabels,
                rows: rows,
                maxCount: ref maxCount,
                colorByTotal: ref colorByTotal,
                extension: ref extension);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/export/startexportbubblechartjob",
                baseUri: HttpClient.BaseAddress); 
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
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareExportStartExportBubbleChartJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                projectId: projectId,
                title: title,
                columnLabels: columnLabels,
                rowLabels: rowLabels,
                rows: rows,
                maxCount: maxCount,
                colorByTotal: colorByTotal,
                extension: extension);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessExportStartExportBubbleChartJobResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessExportStartExportBubbleChartJobResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return __content;
        }
    }
}