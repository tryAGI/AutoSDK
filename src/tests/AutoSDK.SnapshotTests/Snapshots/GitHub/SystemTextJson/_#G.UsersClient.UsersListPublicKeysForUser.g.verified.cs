﻿//HintName: G.UsersClient.UsersListPublicKeysForUser.g.cs

#nullable enable

namespace G
{
    public partial class UsersClient
    {
        partial void PrepareUsersListPublicKeysForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username,
            ref int? perPage,
            ref int? page);
        partial void PrepareUsersListPublicKeysForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username,
            int? perPage,
            int? page);
        partial void ProcessUsersListPublicKeysForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersListPublicKeysForUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List public keys for a user<br/>
        /// Lists the _verified_ public SSH keys for a user. This is accessible by anyone.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.KeySimple>> UsersListPublicKeysForUserAsync(
            string username,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUsersListPublicKeysForUserArguments(
                httpClient: _httpClient,
                username: ref username,
                perPage: ref perPage,
                page: ref page);

            var __pathBuilder = new PathBuilder(
                path: $"/users/{username}/keys",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUsersListPublicKeysForUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                username: username,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUsersListPublicKeysForUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUsersListPublicKeysForUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.KeySimple>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}