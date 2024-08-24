//HintName: G.InitImagesClient.GetInitImageById.g.cs

#nullable enable

namespace G
{
    public partial class InitImagesClient
    {
        partial void PrepareGetInitImageByIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id);
        partial void PrepareGetInitImageByIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id);
        partial void ProcessGetInitImageByIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetInitImageByIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get single init image<br/>
        /// This endpoint will return a single init image
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetInitImageByIdResponse> GetInitImageByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetInitImageByIdArguments(
                httpClient: _httpClient,
                id: ref id);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/init-image/{id}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetInitImageByIdRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetInitImageByIdResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetInitImageByIdResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetInitImageByIdResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}