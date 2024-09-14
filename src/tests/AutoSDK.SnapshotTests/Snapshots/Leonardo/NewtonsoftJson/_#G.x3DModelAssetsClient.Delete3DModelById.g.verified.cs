//HintName: G.x3DModelAssetsClient.Delete3DModelById.g.cs

#nullable enable

namespace G
{
    public partial class x3DModelAssetsClient
    {
        partial void PrepareDelete3DModelByIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::G.Delete3DModelByIdRequest request);
        partial void PrepareDelete3DModelByIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::G.Delete3DModelByIdRequest request);
        partial void ProcessDelete3DModelByIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDelete3DModelByIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete 3D Model by ID<br/>
        /// This endpoint deletes the specific 3D Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Delete3DModelByIdResponse> Delete3DModelByIdAsync(
            string id,
            global::G.Delete3DModelByIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDelete3DModelByIdArguments(
                httpClient: _httpClient,
                id: ref id,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/models-3d/{id}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDelete3DModelByIdRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDelete3DModelByIdResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDelete3DModelByIdResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Delete3DModelByIdResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Delete 3D Model by ID<br/>
        /// This endpoint deletes the specific 3D Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Delete3DModelByIdResponse> Delete3DModelByIdAsync(
            string id,
            string? requestId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Delete3DModelByIdRequest
            {
                Id = requestId,
            };

            return await Delete3DModelByIdAsync(
                id: id,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}