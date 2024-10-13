//HintName: G.BulkExportsClient.CancelBulkExport.g.cs

#nullable enable

namespace G
{
    public partial class BulkExportsClient
    {
        partial void PrepareCancelBulkExportArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid bulkExportId,
            global::G.BulkExportUpdate request);
        partial void PrepareCancelBulkExportRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid bulkExportId,
            global::G.BulkExportUpdate request);
        partial void ProcessCancelBulkExportResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCancelBulkExportResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Cancel Bulk Export<br/>
        /// Cancel a bulk export by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BulkExport> CancelBulkExportAsync(
            global::System.Guid bulkExportId,
            global::G.BulkExportUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCancelBulkExportArguments(
                httpClient: _httpClient,
                bulkExportId: ref bulkExportId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/bulk-exports/{bulkExportId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCancelBulkExportRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                bulkExportId: bulkExportId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCancelBulkExportResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCancelBulkExportResponseContent(
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
                global::G.BulkExport.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Cancel Bulk Export<br/>
        /// Cancel a bulk export by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BulkExport> CancelBulkExportAsync(
            global::System.Guid bulkExportId,
            global::G.BulkExportUpdateStatus status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BulkExportUpdate
            {
                Status = status,
            };

            return await CancelBulkExportAsync(
                bulkExportId: bulkExportId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}