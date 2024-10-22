//HintName: G.UsersClient.UsersCreatePublicSshKeyForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersCreatePublicSshKeyForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UsersCreatePublicSshKeyForAuthenticatedUserRequest request);
        partial void PrepareUsersCreatePublicSshKeyForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UsersCreatePublicSshKeyForAuthenticatedUserRequest request);
        partial void ProcessUsersCreatePublicSshKeyForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersCreatePublicSshKeyForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a public SSH key for the authenticated user<br/>
        /// Adds a public SSH key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Key> UsersCreatePublicSshKeyForAuthenticatedUserAsync(
            global::G.UsersCreatePublicSshKeyForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUsersCreatePublicSshKeyForAuthenticatedUserArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/user/keys",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUsersCreatePublicSshKeyForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUsersCreatePublicSshKeyForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUsersCreatePublicSshKeyForAuthenticatedUserResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.Key.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a public SSH key for the authenticated user<br/>
        /// Adds a public SSH key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="title">
        /// A descriptive name for the new key.<br/>
        /// Example: Personal MacBook Air
        /// </param>
        /// <param name="key">
        /// The public SSH key to add to your GitHub account.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Key> UsersCreatePublicSshKeyForAuthenticatedUserAsync(
            string key,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UsersCreatePublicSshKeyForAuthenticatedUserRequest
            {
                Title = title,
                Key = key,
            };

            return await UsersCreatePublicSshKeyForAuthenticatedUserAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}