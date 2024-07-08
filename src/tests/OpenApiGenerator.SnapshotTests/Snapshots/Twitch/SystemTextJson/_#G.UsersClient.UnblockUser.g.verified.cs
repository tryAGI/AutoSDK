//HintName: G.UsersClient.UnblockUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUnblockUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string targetUserId);
        partial void PrepareUnblockUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string targetUserId);
        partial void ProcessUnblockUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Removes the user from the broadcaster’s list of blocked users.<br/>
        /// Removes the user from the broadcaster’s list of blocked users. The user ID in the OAuth token identifies the broadcaster who’s removing the block.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:blocked\_users** scope.
        /// </summary>
        /// <param name="targetUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UnblockUserAsync(
            string targetUserId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUnblockUserArguments(
                httpClient: _httpClient,
                targetUserId: ref targetUserId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/users/blocks?target_user_id={targetUserId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUnblockUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                targetUserId: targetUserId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUnblockUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}