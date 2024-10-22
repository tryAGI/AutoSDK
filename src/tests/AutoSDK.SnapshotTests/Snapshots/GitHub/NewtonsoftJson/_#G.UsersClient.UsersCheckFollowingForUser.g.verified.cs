//HintName: G.UsersClient.UsersCheckFollowingForUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersCheckFollowingForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username,
            ref string targetUser);
        partial void PrepareUsersCheckFollowingForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username,
            string targetUser);
        partial void ProcessUsersCheckFollowingForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Check if a user follows another user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="targetUser"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UsersCheckFollowingForUserAsync(
            string username,
            string targetUser,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUsersCheckFollowingForUserArguments(
                httpClient: HttpClient,
                username: ref username,
                targetUser: ref targetUser);

            var __pathBuilder = new PathBuilder(
                path: $"/users/{username}/following/{targetUser}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUsersCheckFollowingForUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                username: username,
                targetUser: targetUser);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUsersCheckFollowingForUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}