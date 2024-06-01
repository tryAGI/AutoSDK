//HintName: G.CodespacesClient.CodespacesUpdateForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        /// <summary>
        /// Update a codespace for the authenticated user
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Codespace> CodespacesUpdateForAuthenticatedUserAsync(
            string codespaceName,
            CodespacesUpdateForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/user/codespaces/{codespaceName}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<Codespace?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a codespace for the authenticated user
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="machine"></param>
        /// <param name="displayName"></param>
        /// <param name="recentFolders"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Codespace> CodespacesUpdateForAuthenticatedUserAsync(
            string codespaceName,
            string? machine = default,
            string? displayName = default,
            global::System.Collections.Generic.IList<string?>? recentFolders = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CodespacesUpdateForAuthenticatedUserRequest
            {
                Machine = machine,
                DisplayName = displayName,
                RecentFolders = recentFolders,
            };

            return await CodespacesUpdateForAuthenticatedUserAsync(
                codespaceName: codespaceName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}