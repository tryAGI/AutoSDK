//HintName: G.CodespacesClient.CodespacesPublishForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        partial void PrepareCodespacesPublishForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string codespaceName,
            global::G.CodespacesPublishForAuthenticatedUserRequest request);
        partial void PrepareCodespacesPublishForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string codespaceName,
            global::G.CodespacesPublishForAuthenticatedUserRequest request);
        partial void ProcessCodespacesPublishForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodespacesPublishForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a repository from an unpublished codespace<br/>
        /// Publishes an unpublished codespace, creating a new repository and assigning it to the codespace.<br/>
        /// The codespace's token is granted write permissions to the repository, allowing the user to push their changes.<br/>
        /// This will fail for a codespace that is already published, meaning it has an associated repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodespaceWithFullRepository> CodespacesPublishForAuthenticatedUserAsync(
            string codespaceName,
            global::G.CodespacesPublishForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCodespacesPublishForAuthenticatedUserArguments(
                httpClient: _httpClient,
                codespaceName: ref codespaceName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/codespaces/{codespaceName}/publish", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodespacesPublishForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                codespaceName: codespaceName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodespacesPublishForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodespacesPublishForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodespaceWithFullRepository?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a repository from an unpublished codespace<br/>
        /// Publishes an unpublished codespace, creating a new repository and assigning it to the codespace.<br/>
        /// The codespace's token is granted write permissions to the repository, allowing the user to push their changes.<br/>
        /// This will fail for a codespace that is already published, meaning it has an associated repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="name">
        /// A name for the new repository.
        /// </param>
        /// <param name="private">
        /// Whether the new repository should be private.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CodespaceWithFullRepository> CodespacesPublishForAuthenticatedUserAsync(
            string codespaceName,
            string? name = default,
            bool @private = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CodespacesPublishForAuthenticatedUserRequest
            {
                Name = name,
                Private = @private,
            };

            return await CodespacesPublishForAuthenticatedUserAsync(
                codespaceName: codespaceName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}