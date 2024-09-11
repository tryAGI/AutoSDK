//HintName: G.PointersClient.PointersPatchV4PointersPointerPatch.g.cs

#nullable enable

namespace G
{
    public partial class PointersClient
    {
        partial void PreparePointersPatchV4PointersPointerPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pointer,
            global::G.PointerPatch request);
        partial void PreparePointersPatchV4PointersPointerPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pointer,
            global::G.PointerPatch request);
        partial void ProcessPointersPatchV4PointersPointerPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPointersPatchV4PointersPointerPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Pointers Patch<br/>
        /// Update a pipeline pointer instance.
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PointerGet> PointersPatchV4PointersPointerPatchAsync(
            string pointer,
            global::G.PointerPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePointersPatchV4PointersPointerPatchArguments(
                httpClient: _httpClient,
                pointer: ref pointer,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/pointers/{pointer}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePointersPatchV4PointersPointerPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pointer: pointer,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPointersPatchV4PointersPointerPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPointersPatchV4PointersPointerPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.PointerGet?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Pointers Patch<br/>
        /// Update a pipeline pointer instance.
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="pointerOrPipelineId"></param>
        /// <param name="locked"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PointerGet> PointersPatchV4PointersPointerPatchAsync(
            string pointer,
            string? pointerOrPipelineId = default,
            bool locked = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PointerPatch
            {
                PointerOrPipelineId = pointerOrPipelineId,
                Locked = locked,
            };

            return await PointersPatchV4PointersPointerPatchAsync(
                pointer: pointer,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}