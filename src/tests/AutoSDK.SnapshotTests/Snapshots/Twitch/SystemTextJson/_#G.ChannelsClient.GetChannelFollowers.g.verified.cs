//HintName: G.ChannelsClient.GetChannelFollowers.g.cs

#nullable enable

namespace G
{
    public partial class ChannelsClient
    {
        partial void PrepareGetChannelFollowersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? userId,
            ref string broadcasterId,
            ref int? first,
            ref string? after);
        partial void PrepareGetChannelFollowersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? userId,
            string broadcasterId,
            int? first,
            string? after);
        partial void ProcessGetChannelFollowersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetChannelFollowersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets a list of users that follow the specified broadcaster. You can also use this endpoint to see whether a specific user follows the broadcaster.<br/>
        /// Gets a list of users that follow the specified broadcaster. You can also use this endpoint to see whether a specific user follows the broadcaster.<br/>
        /// __Authorization:__<br/>
        /// * Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:read:followers** scope.<br/>
        /// * The ID in the broadcaster\_id query parameter must match the user ID in the access token or the user ID in the access token must be a moderator for the specified broadcaster.<br/>
        /// This endpoint will return specific follower information only if both of the above are true. If a scope is not provided or the user isn’t the broadcaster or a moderator for the specified channel, only the total follower count will be included in the response.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetChannelFollowersResponse> GetChannelFollowersAsync(
            string broadcasterId,
            string? userId = default,
            int? first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetChannelFollowersArguments(
                httpClient: _httpClient,
                userId: ref userId,
                broadcasterId: ref broadcasterId,
                first: ref first,
                after: ref after);

            var __pathBuilder = new PathBuilder(
                path: "/channels/followers",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("user_id", userId) 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                .AddOptionalParameter("first", first?.ToString()) 
                .AddOptionalParameter("after", after) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetChannelFollowersRequest(
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
            ProcessGetChannelFollowersResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetChannelFollowersResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetChannelFollowersResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}