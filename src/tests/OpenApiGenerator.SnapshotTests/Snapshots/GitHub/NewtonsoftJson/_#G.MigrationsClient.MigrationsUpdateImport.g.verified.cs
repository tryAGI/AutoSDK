//HintName: G.MigrationsClient.MigrationsUpdateImport.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsUpdateImportArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.MigrationsUpdateImportRequest request);
        partial void PrepareMigrationsUpdateImportRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.MigrationsUpdateImportRequest request);
        partial void ProcessMigrationsUpdateImportResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsUpdateImportResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an import<br/>
        /// An import can be updated with credentials or a project choice by passing in the appropriate parameters in this API<br/>
        /// request. If no parameters are provided, the import will be restarted.<br/>
        /// Some servers (e.g. TFS servers) can have several projects at a single URL. In those cases the import progress will<br/>
        /// have the status `detection_found_multiple` and the Import Progress response will include a `project_choices` array.<br/>
        /// You can select the project to import by providing one of the objects in the `project_choices` array in the update request.<br/>
        /// **Warning:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.Import> MigrationsUpdateImportAsync(
            string owner,
            string repo,
            global::G.MigrationsUpdateImportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareMigrationsUpdateImportArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/import", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMigrationsUpdateImportRequest(
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
            ProcessMigrationsUpdateImportResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMigrationsUpdateImportResponseContent(
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
        /// Update an import<br/>
        /// An import can be updated with credentials or a project choice by passing in the appropriate parameters in this API<br/>
        /// request. If no parameters are provided, the import will be restarted.<br/>
        /// Some servers (e.g. TFS servers) can have several projects at a single URL. In those cases the import progress will<br/>
        /// have the status `detection_found_multiple` and the Import Progress response will include a `project_choices` array.<br/>
        /// You can select the project to import by providing one of the objects in the `project_choices` array in the update request.<br/>
        /// **Warning:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="vcsUsername">
        /// The username to provide to the originating repository.
        /// </param>
        /// <param name="vcsPassword">
        /// The password to provide to the originating repository.
        /// </param>
        /// <param name="vcs">
        /// The type of version control system you are migrating from.<br/>
        /// Example: "git"
        /// </param>
        /// <param name="tfvcProject">
        /// For a tfvc import, the name of the project that is being imported.<br/>
        /// Example: "project1"
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::G.Import> MigrationsUpdateImportAsync(
            string owner,
            string repo,
            string? vcsUsername = default,
            string? vcsPassword = default,
            global::G.MigrationsUpdateImportRequestVcs? vcs = default,
            string? tfvcProject = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.MigrationsUpdateImportRequest
            {
                VcsUsername = vcsUsername,
                VcsPassword = vcsPassword,
                Vcs = vcs,
                TfvcProject = tfvcProject,
            };

            return await MigrationsUpdateImportAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}