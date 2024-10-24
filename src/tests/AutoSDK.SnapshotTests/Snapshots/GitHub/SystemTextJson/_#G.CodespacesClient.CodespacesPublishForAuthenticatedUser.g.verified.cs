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
                client: HttpClient);
            PrepareCodespacesPublishForAuthenticatedUserArguments(
                httpClient: HttpClient,
                codespaceName: ref codespaceName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/user/codespaces/{codespaceName}/publish",
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
            PrepareCodespacesPublishForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                codespaceName: codespaceName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCodespacesPublishForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCodespacesPublishForAuthenticatedUserResponseContent(
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
                global::G.CodespaceWithFullRepository.FromJson(__content, JsonSerializerOptions) ??
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
            bool? @private = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CodespacesPublishForAuthenticatedUserRequest
            {
                Name = name,
                Private = @private,
            };

            return await CodespacesPublishForAuthenticatedUserAsync(
                codespaceName: codespaceName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}