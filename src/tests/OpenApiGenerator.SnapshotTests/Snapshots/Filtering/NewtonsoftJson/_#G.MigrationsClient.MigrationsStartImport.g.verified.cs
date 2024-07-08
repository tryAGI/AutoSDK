//HintName: G.MigrationsClient.MigrationsStartImport.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsStartImportArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.MigrationsStartImportRequest request);
        partial void PrepareMigrationsStartImportRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.MigrationsStartImportRequest request);
        partial void ProcessMigrationsStartImportResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsStartImportResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start an import<br/>
        /// Start a source import to a GitHub repository using GitHub Importer.<br/>
        /// Importing into a GitHub repository with GitHub Actions enabled is not supported and will<br/>
        /// return a status `422 Unprocessable Entity` response.<br/>
        /// **Warning:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.Import> MigrationsStartImportAsync(
            string owner,
            string repo,
            global::G.MigrationsStartImportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareMigrationsStartImportArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/import", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMigrationsStartImportRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMigrationsStartImportResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMigrationsStartImportResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Import?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Start an import<br/>
        /// Start a source import to a GitHub repository using GitHub Importer.<br/>
        /// Importing into a GitHub repository with GitHub Actions enabled is not supported and will<br/>
        /// return a status `422 Unprocessable Entity` response.<br/>
        /// **Warning:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
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
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.Import> MigrationsStartImportAsync(
            string owner,
            string repo,
            string vcsUrl,
            global::G.MigrationsStartImportRequestVcs? vcs = default,
            string? vcsUsername = default,
            string? vcsPassword = default,
            string? tfvcProject = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.MigrationsStartImportRequest
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