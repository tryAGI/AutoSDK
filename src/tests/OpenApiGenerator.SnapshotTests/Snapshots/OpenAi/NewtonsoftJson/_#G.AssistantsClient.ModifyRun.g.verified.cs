//HintName: G.AssistantsClient.ModifyRun.g.cs

#nullable enable

namespace G
{
    public partial class AssistantsClient
    {
        partial void PrepareModifyRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            ref string runId,
            global::G.ModifyRunRequest request);
        partial void PrepareModifyRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            string runId,
            global::G.ModifyRunRequest request);
        partial void ProcessModifyRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModifyRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Modifies a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunObject> ModifyRunAsync(
            string threadId,
            string runId,
            global::G.ModifyRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareModifyRunArguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                runId: ref runId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/threads/{threadId}/runs/{runId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareModifyRunRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
                runId: runId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessModifyRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessModifyRunResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RunObject?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Modifies a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RunObject> ModifyRunAsync(
            string threadId,
            string runId,
            global::G.ModifyRunRequestMetadata? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ModifyRunRequest
            {
                Metadata = metadata,
            };

            return await ModifyRunAsync(
                threadId: threadId,
                runId: runId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}