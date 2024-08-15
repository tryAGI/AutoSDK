//HintName: G.CodespacesClient.CodespacesSetRepositoriesForSecretForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        partial void PrepareCodespacesSetRepositoriesForSecretForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string secretName,
            global::G.CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest request);
        partial void PrepareCodespacesSetRepositoriesForSecretForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string secretName,
            global::G.CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest request);
        partial void ProcessCodespacesSetRepositoriesForSecretForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodespacesSetRepositoriesForSecretForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Set selected repositories for a user secret<br/>
        /// Select the repositories that will use a user's development environment secret.<br/>
        /// The authenticated user must have Codespaces access to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` or `codespace:secrets` scope to use this endpoint.
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> CodespacesSetRepositoriesForSecretForAuthenticatedUserAsync(
            string secretName,
            global::G.CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCodespacesSetRepositoriesForSecretForAuthenticatedUserArguments(
                httpClient: _httpClient,
                secretName: ref secretName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/codespaces/secrets/{secretName}/repositories", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodespacesSetRepositoriesForSecretForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                secretName: secretName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodespacesSetRepositoriesForSecretForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodespacesSetRepositoriesForSecretForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.BasicError?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set selected repositories for a user secret<br/>
        /// Select the repositories that will use a user's development environment secret.<br/>
        /// The authenticated user must have Codespaces access to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` or `codespace:secrets` scope to use this endpoint.
        /// </summary>
        /// <param name="secretName"></param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository ids for which a codespace can access the secret. You can manage the list of selected repositories using the [List selected repositories for a user secret](https://docs.github.com/rest/codespaces/secrets#list-selected-repositories-for-a-user-secret), [Add a selected repository to a user secret](https://docs.github.com/rest/codespaces/secrets#add-a-selected-repository-to-a-user-secret), and [Remove a selected repository from a user secret](https://docs.github.com/rest/codespaces/secrets#remove-a-selected-repository-from-a-user-secret) endpoints.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BasicError> CodespacesSetRepositoriesForSecretForAuthenticatedUserAsync(
            string secretName,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest
            {
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            return await CodespacesSetRepositoriesForSecretForAuthenticatedUserAsync(
                secretName: secretName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}