//HintName: G.ChatClient.GetUserEmotes.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareGetUserEmotesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userId,
            ref string? broadcasterId,
            ref string? after);
        partial void PrepareGetUserEmotesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userId,
            string? broadcasterId,
            string? after);
        partial void ProcessGetUserEmotesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetUserEmotesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// NEW Retrieves emotes available to the user across all channels.<br/>
        /// NEW Retrieves emotes available to the user across all channels.<br/>
        /// __Authorization:__<br/>
        /// * Requires a user access token that includes the **user:read:emotes** scope.<br/>
        /// * Query parameter `user_id` must match the `user_id` in the user access token.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetUserEmotesResponse> GetUserEmotesAsync(
            string userId,
            string? broadcasterId = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetUserEmotesArguments(
                httpClient: _httpClient,
                userId: ref userId,
                broadcasterId: ref broadcasterId,
                after: ref after);

            var __pathBuilder = new PathBuilder(
                path: "/chat/emotes/user",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("user_id", userId) 
                .AddOptionalParameter("broadcaster_id", broadcasterId) 
                .AddOptionalParameter("after", after) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetUserEmotesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId,
                broadcasterId: broadcasterId,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetUserEmotesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetUserEmotesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetUserEmotesResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}