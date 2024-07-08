//HintName: G.AssistantsClient.CreateThread.g.cs

#nullable enable

namespace G
{
    public partial class AssistantsClient
    {
        partial void PrepareCreateThreadArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateThreadRequest request);
        partial void PrepareCreateThreadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateThreadRequest request);
        partial void ProcessCreateThreadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateThreadResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a thread.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ThreadObject> CreateThreadAsync(
            global::G.CreateThreadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateThreadArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/threads", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateThreadRequest(
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
            ProcessCreateThreadResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateThreadResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ThreadObject?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a thread.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ThreadObject> CreateThreadAsync(
            global::System.Collections.Generic.IList<global::G.CreateMessageRequest>? messages = default,
            global::G.CreateThreadRequestToolResources? toolResources = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateThreadRequest
            {
                Messages = messages,
                ToolResources = toolResources,
                Metadata = metadata,
            };

            return await CreateThreadAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}