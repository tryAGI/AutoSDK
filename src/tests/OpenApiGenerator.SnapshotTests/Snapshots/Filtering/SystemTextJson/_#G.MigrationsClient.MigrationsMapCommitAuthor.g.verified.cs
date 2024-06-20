//HintName: G.MigrationsClient.MigrationsMapCommitAuthor.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        /// <summary>
        /// Map a commit author<br/>
        /// Update an author's identity for the import. Your application can continue updating authors any time before you push<br/>
        /// new commits to the repository.<br/>
        /// **Warning:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="authorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.PorterAuthor> MigrationsMapCommitAuthorAsync(
            string owner,
            string repo,
            int authorId,
            global::G.MigrationsMapCommitAuthorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/import/authors/{authorId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.PorterAuthor?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Map a commit author<br/>
        /// Update an author's identity for the import. Your application can continue updating authors any time before you push<br/>
        /// new commits to the repository.<br/>
        /// **Warning:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="authorId"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.PorterAuthor> MigrationsMapCommitAuthorAsync(
            string owner,
            string repo,
            int authorId,
            string? email = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.MigrationsMapCommitAuthorRequest
            {
                Email = email,
                Name = name,
            };

            return await MigrationsMapCommitAuthorAsync(
                owner: owner,
                repo: repo,
                authorId: authorId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}