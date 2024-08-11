//HintName: G.UsersClient.UsersGetByUsername.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersGetByUsernameArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username);
        partial void PrepareUsersGetByUsernameRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username);
        partial void ProcessUsersGetByUsernameResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersGetByUsernameResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a user<br/>
        /// Provides publicly available information about someone with a GitHub account.<br/>
        /// The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#authentication).<br/>
        /// The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see "[Emails API](https://docs.github.com/rest/users/emails)".
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.OneOf<global::G.PrivateUser?, global::G.PublicUser?>> UsersGetByUsernameAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUsersGetByUsernameArguments(
                httpClient: _httpClient,
                username: ref username);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/users/{username}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUsersGetByUsernameRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                username: username);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUsersGetByUsernameResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUsersGetByUsernameResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.OneOf<global::G.PrivateUser?, global::G.PublicUser?>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}