//HintName: G.DatasetsClient.UploadCsvDataset.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareUploadCsvDatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPost request);
        partial void PrepareUploadCsvDatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPost request);
        partial void ProcessUploadCsvDatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadCsvDatasetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Csv Dataset<br/>
        /// Create a new dataset from a CSV file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Dataset> UploadCsvDatasetAsync(
            global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUploadCsvDatasetArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/datasets/upload", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUploadCsvDatasetRequest(
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
            ProcessUploadCsvDatasetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUploadCsvDatasetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Dataset?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload Csv Dataset<br/>
        /// Create a new dataset from a CSV file.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="inputKeys"></param>
        /// <param name="name"></param>
        /// <param name="dataType">
        /// Default Value: kv
        /// </param>
        /// <param name="outputKeys"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Dataset> UploadCsvDatasetAsync(
            byte[] file,
            global::System.Collections.Generic.IList<string> inputKeys,
            global::System.AnyOf<string?, object?>? name = default,
            global::System.AllOf<global::G.DataType?>? dataType = default,
            global::System.Collections.Generic.IList<string?>? outputKeys = default,
            global::System.AnyOf<string?, object?>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPost
            {
                File = file,
                InputKeys = inputKeys,
                Name = name,
                DataType = dataType,
                OutputKeys = outputKeys,
                Description = description,
            };

            return await UploadCsvDatasetAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}