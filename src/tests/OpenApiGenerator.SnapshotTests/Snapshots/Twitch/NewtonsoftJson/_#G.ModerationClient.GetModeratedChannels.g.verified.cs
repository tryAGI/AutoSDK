//HintName: G.ModerationClient.GetModeratedChannels.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        partial void PrepareGetModeratedChannelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userId,
            ref string? after,
            ref int first);
        partial void PrepareGetModeratedChannelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userId,
            string? after,
            int first);
        partial void ProcessGetModeratedChannelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetModeratedChannelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of channels that the specified user has moderator privileges in.<br/>
        /// Gets a list of channels that the specified user has moderator privileges in.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `user_id` must match the user ID in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `user:read:moderated_channels`
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="after"></param>
        /// <param name="first"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetModeratedChannelsResponse> GetModeratedChannelsAsync(
            string userId,
            string? after,
            int first,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetModeratedChannelsArguments(
                httpClient: _httpClient,
                userId: ref userId,
                after: ref after,
                first: ref first);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/moderation/channels?user_id={userId}&after={after}&first={first}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetModeratedChannelsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId,
                after: after,
                first: first);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetModeratedChannelsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetModeratedChannelsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetModeratedChannelsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}