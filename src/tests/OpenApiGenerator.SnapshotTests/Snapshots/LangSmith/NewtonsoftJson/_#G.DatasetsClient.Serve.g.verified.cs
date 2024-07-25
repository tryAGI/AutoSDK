//HintName: G.DatasetsClient.Serve.g.cs

#nullable enable

namespace G
{
    public partial class DatasetsClient
    {
        partial void PrepareServeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::G.DatasetServeRequest request);
        partial void PrepareServeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::G.DatasetServeRequest request);
        partial void ProcessServeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessServeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Serve<br/>
        /// Serve a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> ServeAsync(
            string datasetId,
            global::G.DatasetServeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareServeArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/serve", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareServeRequest(
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
            ProcessServeResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessServeResponseContent(
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

        /// <summary>
        /// Serve<br/>
        /// Serve a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="tag">
        /// Default Value: latest
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<object> ServeAsync(
            string datasetId,
            global::System.AnyOf<string?, object?>? tag = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.DatasetServeRequest
            {
                Tag = tag,
            };

            return await ServeAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}