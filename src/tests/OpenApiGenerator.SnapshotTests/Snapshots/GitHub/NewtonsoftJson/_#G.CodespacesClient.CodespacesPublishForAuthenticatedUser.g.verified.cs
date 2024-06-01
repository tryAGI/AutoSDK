//HintName: G.CodespacesClient.CodespacesPublishForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        /// <summary>
        /// Create a repository from an unpublished codespace
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CodespaceWithFullRepository> CodespacesPublishForAuthenticatedUserAsync(
            string codespaceName,
            CodespacesPublishForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/codespaces/{codespaceName}/publish", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<CodespaceWithFullRepository?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a repository from an unpublished codespace
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="name"></param>
        /// <param name="@private"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CodespaceWithFullRepository> CodespacesPublishForAuthenticatedUserAsync(
            string codespaceName,
            string? name = default,
            bool @private = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CodespacesPublishForAuthenticatedUserRequest
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