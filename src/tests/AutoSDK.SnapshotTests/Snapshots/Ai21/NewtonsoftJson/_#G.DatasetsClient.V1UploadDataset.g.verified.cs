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
        public async global::System.Threading.Tasks.Task<string> V1UploadDatasetAsync(
            global::G.BodyV1UploadDataset request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1UploadDatasetArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/dataset",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.DatasetFile ?? global::System.Array.Empty<byte>()),
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
            if (request.SplitRatio != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SplitRatio}"),
                    name: "split_ratio");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1UploadDatasetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1UploadDatasetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1UploadDatasetResponseContent(
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
        public async global::System.Threading.Tasks.Task<string> V1UploadDatasetAsync(
            byte[] datasetFile,
            string datasetFilename,
            string datasetName,
            string? selectedColumns = default,
            bool? approveWhitespaceCorrection = default,
            bool? deleteLongRows = default,
            double? splitRatio = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyV1UploadDataset
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
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}