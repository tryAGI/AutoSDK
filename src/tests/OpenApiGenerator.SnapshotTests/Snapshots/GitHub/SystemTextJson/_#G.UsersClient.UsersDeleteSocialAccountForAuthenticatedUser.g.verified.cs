//HintName: G.UsersClient.UsersDeleteSocialAccountForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersDeleteSocialAccountForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.UsersDeleteSocialAccountForAuthenticatedUserRequest request);
        partial void PrepareUsersDeleteSocialAccountForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.UsersDeleteSocialAccountForAuthenticatedUserRequest request);
        partial void ProcessUsersDeleteSocialAccountForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersDeleteSocialAccountForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete social accounts for the authenticated user<br/>
        /// Deletes one or more social accounts from the authenticated user's profile.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ValidationError> UsersDeleteSocialAccountForAuthenticatedUserAsync(
            global::G.UsersDeleteSocialAccountForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUsersDeleteSocialAccountForAuthenticatedUserArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/user/social_accounts", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUsersDeleteSocialAccountForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUsersDeleteSocialAccountForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUsersDeleteSocialAccountForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ValidationError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Delete social accounts for the authenticated user<br/>
        /// Deletes one or more social accounts from the authenticated user's profile.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="accountUrls">
        /// Full URLs for the social media profiles to delete.<br/>
        /// Example: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ValidationError> UsersDeleteSocialAccountForAuthenticatedUserAsync(
            global::System.Collections.Generic.IList<string> accountUrls,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UsersDeleteSocialAccountForAuthenticatedUserRequest
            {
                AccountUrls = accountUrls,
            };

            return await UsersDeleteSocialAccountForAuthenticatedUserAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}