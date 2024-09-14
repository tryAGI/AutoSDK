//HintName: G.StreamingAPIClient.StreamingInterrupt.g.cs

#nullable enable

namespace G
{
    public partial class StreamingAPIClient
    {
        partial void PrepareStreamingInterruptArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.StreamingInterruptRequest request);
        partial void PrepareStreamingInterruptRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.StreamingInterruptRequest request);
        partial void ProcessStreamingInterruptResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// streaming.interrupt<br/>
        /// This is endpoint is to interrupt a speaking avatar. If the avatar is not speaking, it doesn't do anything.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task StreamingInterruptAsync(
            global::G.StreamingInterruptRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareStreamingInterruptArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/v1/streaming.interrupt", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareStreamingInterruptRequest(
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
            ProcessStreamingInterruptResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// streaming.interrupt<br/>
        /// This is endpoint is to interrupt a speaking avatar. If the avatar is not speaking, it doesn't do anything.
        /// </summary>
        /// <param name="sessionId">
        /// Example: &lt;session_id&gt;
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task StreamingInterruptAsync(
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.StreamingInterruptRequest
            {
                SessionId = sessionId,
            };

            await StreamingInterruptAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}