//HintName: G.ChatClient.GetUserEmotes.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        partial void PrepareGetUserEmotesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userId,
            ref string broadcasterId,
            ref string after);
        partial void PrepareGetUserEmotesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userId,
            string broadcasterId,
            string after);
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
            string broadcasterId,
            string after,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/chat/emotes/user?user_id={userId}&broadcaster_id={broadcasterId}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetUserEmotesResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}