//HintName: G.ChannelsClient.GetFollowedChannels.g.cs

#nullable enable

namespace G
{
    public partial class ChannelsClient
    {
        partial void PrepareGetFollowedChannelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userId,
            ref string? broadcasterId,
            ref int first,
            ref string? after);
        partial void PrepareGetFollowedChannelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userId,
            string? broadcasterId,
            int first,
            string? after);
        partial void ProcessGetFollowedChannelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetFollowedChannelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of broadcasters that the specified user follows. You can also use this endpoint to see whether a user follows a specific broadcaster.<br/>
        /// Gets a list of broadcasters that the specified user follows. You can also use this endpoint to see whether a user follows a specific broadcaster.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:read:follows** scope.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetFollowedChannelsResponse> GetFollowedChannelsAsync(
            string userId,
            string? broadcasterId = default,
            int first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetFollowedChannelsArguments(
                httpClient: _httpClient,
                userId: ref userId,
                broadcasterId: ref broadcasterId,
                first: ref first,
                after: ref after);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/channels/followed?user_id={userId}&broadcaster_id={broadcasterId}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetFollowedChannelsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId,
                broadcasterId: broadcasterId,
                first: first,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetFollowedChannelsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetFollowedChannelsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetFollowedChannelsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}