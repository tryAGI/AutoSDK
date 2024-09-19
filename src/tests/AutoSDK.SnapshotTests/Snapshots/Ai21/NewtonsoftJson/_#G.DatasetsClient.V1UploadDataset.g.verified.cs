//HintName: G.DatasetsClient.V1UploadDataset.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareV1UploadDatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyV1UploadDataset request);
        partial void PrepareV1UploadDatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyV1UploadDataset request);
        partial void ProcessV1UploadDatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1UploadDatasetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Dataset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.V1UploadDatasetResponse> V1UploadDatasetAsync(
            global::G.BodyV1UploadDataset request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareV1UploadDatasetArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/dataset",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.DatasetFile ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "dataset_file",
                fileName: request.DatasetFilename ?? string.Empty);
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.DatasetName}"),
                name: "dataset_name");
            if (request.SelectedColumns != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SelectedColumns}"),
                    name: "selected_columns");
            } 
            if (request.ApproveWhitespaceCorrection != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ApproveWhitespaceCorrection}"),
                    name: "approve_whitespace_correction");
            } 
            if (request.DeleteLongRows != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DeleteLongRows}"),
                    name: "delete_long_rows");
            } 
            if (request.SplitRatio != 0.1)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SplitRatio}"),
                    name: "split_ratio");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1UploadDatasetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1UploadDatasetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1UploadDatasetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.V1UploadDatasetResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add Dataset
        /// </summary>
        /// <param name="datasetFile"></param>
        /// <param name="datasetFilename"></param>
        /// <param name="datasetName"></param>
        /// <param name="selectedColumns"></param>
        /// <param name="approveWhitespaceCorrection"></param>
        /// <param name="deleteLongRows"></param>
        /// <param name="splitRatio">
        /// Default Value: 0.1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.V1UploadDatasetResponse> V1UploadDatasetAsync(
            byte[] datasetFile,
            string datasetFilename,
            string datasetName,
            string? selectedColumns = default,
            bool? approveWhitespaceCorrection = default,
            bool? deleteLongRows = default,
            double? splitRatio = 0.1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyV1UploadDataset
            {
                DatasetFile = datasetFile,
                DatasetFilename = datasetFilename,
                DatasetName = datasetName,
                SelectedColumns = selectedColumns,
                ApproveWhitespaceCorrection = approveWhitespaceCorrection,
                DeleteLongRows = deleteLongRows,
                SplitRatio = splitRatio,
            };

            return await V1UploadDatasetAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}