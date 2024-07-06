//HintName: G.UsersClient.BlockUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        /// <summary>
        /// Blocks the specified user from interacting with or having contact with the broadcaster.<br/>
        /// Blocks the specified user from interacting with or having contact with the broadcaster. The user ID in the OAuth token identifies the broadcaster who is blocking the user.<br/>
        /// To learn more about blocking users, see [Block Other Users on Twitch](https://help.twitch.tv/s/article/how-to-manage-harassment-in-chat?language=en%5FUS#BlockWhispersandMessagesfromStrangers).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:blocked\_users** scope.
        /// </summary>
        /// <param name="targetUserId"></param>
        /// <param name="sourceContext"></param>
        /// <param name="reason"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task BlockUserAsync(
            string targetUserId,
            global::G.BlockUserSourceContext sourceContext,
            global::G.BlockUserReason reason,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sourceContextValue = sourceContext switch
            {
                global::G.BlockUserSourceContext.Chat => "chat",
                global::G.BlockUserSourceContext.Whisper => "whisper",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var reasonValue = reason switch
            {
                global::G.BlockUserReason.Harassment => "harassment",
                global::G.BlockUserReason.Spam => "spam",
                global::G.BlockUserReason.Other => "other",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/users/blocks?target_user_id={targetUserId}&source_context={sourceContextValue}&reason={reasonValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}