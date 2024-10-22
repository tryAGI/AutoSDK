//HintName: G.UsersClient.UsersCreateSshSigningKeyForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersCreateSshSigningKeyForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UsersCreateSshSigningKeyForAuthenticatedUserRequest request);
        partial void PrepareUsersCreateSshSigningKeyForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UsersCreateSshSigningKeyForAuthenticatedUserRequest request);
        partial void ProcessUsersCreateSshSigningKeyForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersCreateSshSigningKeyForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a SSH signing key for the authenticated user<br/>
        /// Creates an SSH signing key for the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SshSigningKey> UsersCreateSshSigningKeyForAuthenticatedUserAsync(
            global::G.UsersCreateSshSigningKeyForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUsersCreateSshSigningKeyForAuthenticatedUserArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/user/ssh_signing_keys",
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
            PrepareUsersCreateSshSigningKeyForAuthenticatedUserRequest(
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
            ProcessUsersCreateSshSigningKeyForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUsersCreateSshSigningKeyForAuthenticatedUserResponseContent(
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
                global::G.SshSigningKey.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a SSH signing key for the authenticated user<br/>
        /// Creates an SSH signing key for the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="title">
        /// A descriptive name for the new key.<br/>
        /// Example: Personal MacBook Air
        /// </param>
        /// <param name="key">
        /// The public SSH key to add to your GitHub account. For more information, see "[Checking for existing SSH keys](https://docs.github.com/authentication/connecting-to-github-with-ssh/checking-for-existing-ssh-keys)."
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SshSigningKey> UsersCreateSshSigningKeyForAuthenticatedUserAsync(
            string key,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UsersCreateSshSigningKeyForAuthenticatedUserRequest
            {
                Title = title,
                Key = key,
            };

            return await UsersCreateSshSigningKeyForAuthenticatedUserAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}