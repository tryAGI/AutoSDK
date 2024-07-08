//HintName: G.PollsClient.EndPoll.g.cs

#nullable enable

namespace G
{
    public partial class PollsClient
    {
        partial void PrepareEndPollArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.EndPollBody request);
        partial void PrepareEndPollRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.EndPollBody request);
        partial void ProcessEndPollResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEndPollResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// End an active poll.<br/>
        /// Ends an active poll. You have the option to end it or end it and archive it.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EndPollResponse> EndPollAsync(
            global::G.EndPollBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareEndPollArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/polls", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareEndPollRequest(
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
            ProcessEndPollResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessEndPollResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.EndPollResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// End an active poll.<br/>
        /// Ends an active poll. You have the option to end it or end it and archive it.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:polls** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EndPollResponse> EndPollAsync(
            string broadcasterId,
            string id,
            global::G.EndPollBodyStatus status,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.EndPollBody
            {
                BroadcasterId = broadcasterId,
                Id = id,
                Status = status,
            };

            return await EndPollAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}