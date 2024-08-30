//HintName: G.UsersClient.BlockUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareBlockUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string targetUserId,
            ref global::G.BlockUserSourceContext? sourceContext,
            ref global::G.BlockUserReason? reason);
        partial void PrepareBlockUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string targetUserId,
            global::G.BlockUserSourceContext? sourceContext,
            global::G.BlockUserReason? reason);
        partial void ProcessBlockUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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
            global::G.BlockUserSourceContext? sourceContext,
            global::G.BlockUserReason? reason,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareBlockUserArguments(
                httpClient: _httpClient,
                targetUserId: ref targetUserId,
                sourceContext: ref sourceContext,
                reason: ref reason);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/users/blocks?target_user_id={targetUserId}&source_context={(global::System.Uri.EscapeDataString(sourceContext?.ToValueString() ?? string.Empty))}&reason={(global::System.Uri.EscapeDataString(reason?.ToValueString() ?? string.Empty))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareBlockUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                targetUserId: targetUserId,
                sourceContext: sourceContext,
                reason: reason);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessBlockUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}