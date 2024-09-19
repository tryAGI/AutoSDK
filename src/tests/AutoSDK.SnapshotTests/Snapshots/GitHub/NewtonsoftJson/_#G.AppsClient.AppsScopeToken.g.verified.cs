//HintName: G.AppsClient.AppsScopeToken.g.cs

#nullable enable

namespace G
{
    public partial class AppsClient
    {
        partial void PrepareAppsScopeTokenArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clientId,
            global::G.AppsScopeTokenRequest request);
        partial void PrepareAppsScopeTokenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clientId,
            global::G.AppsScopeTokenRequest request);
        partial void ProcessAppsScopeTokenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppsScopeTokenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a scoped access token<br/>
        /// Use a non-scoped user access token to create a repository-scoped and/or permission-scoped user access token. You can specify<br/>
        /// which repositories the token can access and which permissions are granted to the<br/>
        /// token.<br/>
        /// Invalid tokens will return `404 NOT FOUND`.<br/>
        /// You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)<br/>
        /// when accessing this endpoint, using the `client_id` and `client_secret` of the GitHub App<br/>
        /// as the username and password.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Authorization> AppsScopeTokenAsync(
            string clientId,
            global::G.AppsScopeTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareAppsScopeTokenArguments(
                httpClient: _httpClient,
                clientId: ref clientId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/applications/{clientId}/token/scoped",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAppsScopeTokenRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                clientId: clientId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAppsScopeTokenResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAppsScopeTokenResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Authorization?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a scoped access token<br/>
        /// Use a non-scoped user access token to create a repository-scoped and/or permission-scoped user access token. You can specify<br/>
        /// which repositories the token can access and which permissions are granted to the<br/>
        /// token.<br/>
        /// Invalid tokens will return `404 NOT FOUND`.<br/>
        /// You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)<br/>
        /// when accessing this endpoint, using the `client_id` and `client_secret` of the GitHub App<br/>
        /// as the username and password.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="accessToken">
        /// The access token used to authenticate to the GitHub API.<br/>
        /// Example: e72e16c7e42f292c6912e7710c838347ae178b4a
        /// </param>
        /// <param name="target">
        /// The name of the user or organization to scope the user access token to. **Required** unless `target_id` is specified.<br/>
        /// Example: octocat
        /// </param>
        /// <param name="targetId">
        /// The ID of the user or organization to scope the user access token to. **Required** unless `target` is specified.<br/>
        /// Example: 1
        /// </param>
        /// <param name="repositories">
        /// The list of repository names to scope the user access token to. `repositories` may not be specified if `repository_ids` is specified.
        /// </param>
        /// <param name="repositoryIds">
        /// The list of repository IDs to scope the user access token to. `repository_ids` may not be specified if `repositories` is specified.<br/>
        /// Example: [1]
        /// </param>
        /// <param name="permissions">
        /// The permissions granted to the user access token.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Authorization> AppsScopeTokenAsync(
            string clientId,
            string accessToken,
            string? target = default,
            int? targetId = default,
            global::System.Collections.Generic.IList<string>? repositories = default,
            global::System.Collections.Generic.IList<int>? repositoryIds = default,
            global::G.AppPermissions? permissions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.AppsScopeTokenRequest
            {
                AccessToken = accessToken,
                Target = target,
                TargetId = targetId,
                Repositories = repositories,
                RepositoryIds = repositoryIds,
                Permissions = permissions,
            };

            return await AppsScopeTokenAsync(
                clientId: clientId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}