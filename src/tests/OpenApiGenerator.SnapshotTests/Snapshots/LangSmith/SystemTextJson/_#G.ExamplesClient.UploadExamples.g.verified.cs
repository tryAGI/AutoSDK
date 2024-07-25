//HintName: G.ExamplesClient.UploadExamples.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareUploadExamplesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::G.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost request);
        partial void PrepareUploadExamplesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::G.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost request);
        partial void ProcessUploadExamplesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadExamplesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Examples<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Example>> UploadExamplesAsync(
            string datasetId,
            global::G.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUploadExamplesArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/examples/upload/{datasetId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUploadExamplesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUploadExamplesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUploadExamplesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Example>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload Examples<br/>
        /// Create a new example.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="file"></param>
        /// <param name="inputKeys"></param>
        /// <param name="outputKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Example>> UploadExamplesAsync(
            string datasetId,
            byte[] file,
            global::System.Collections.Generic.IList<string> inputKeys,
            global::System.Collections.Generic.IList<string?>? outputKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BodyUploadExamplesApiV1ExamplesUploadDatasetIdPost
            {
                File = file,
                InputKeys = inputKeys,
                OutputKeys = outputKeys,
            };

            return await UploadExamplesAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}