//HintName: G.MigrationsClient.MigrationsStartImport.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        /// <summary>
        /// Start an import
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Import> MigrationsStartImportAsync(
            string owner,
            string repo,
            MigrationsStartImportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/import", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<Import>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Start an import
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="vcsUrl"></param>
        /// <param name="vcs"></param>
        /// <param name="vcsUsername"></param>
        /// <param name="vcsPassword"></param>
        /// <param name="tfvcProject"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<Import> MigrationsStartImportAsync(
            string owner,
            string repo,
            string vcsUrl,
            string? vcs = default,
            string? vcsUsername = default,
            string? vcsPassword = default,
            string? tfvcProject = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new MigrationsStartImportRequest
            {
                VcsUrl = vcsUrl,
                Vcs = vcs,
                VcsUsername = vcsUsername,
                VcsPassword = vcsPassword,
                TfvcProject = tfvcProject,
            };

            return await MigrationsStartImportAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}