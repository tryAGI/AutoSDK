//HintName: G.ChatClient.UpdateUserChatColor.g.cs

#nullable enable

namespace G
{
    public partial class ChatClient
    {
        /// <summary>
        /// Updates the color used for the user’s name in chat.<br/>
        /// Updates the color used for the user’s name in chat.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:chat\_color** scope.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="color"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateUserChatColorAsync(
            string userId,
            global::G.UpdateUserChatColorColor color,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + $"/chat/color?user_id={userId}&color={color}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}