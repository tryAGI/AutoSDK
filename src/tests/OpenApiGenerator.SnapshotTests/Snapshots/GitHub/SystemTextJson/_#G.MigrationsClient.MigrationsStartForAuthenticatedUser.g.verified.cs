//HintName: G.MigrationsClient.MigrationsStartForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsStartForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.MigrationsStartForAuthenticatedUserRequest request);
        partial void PrepareMigrationsStartForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.MigrationsStartForAuthenticatedUserRequest request);
        partial void ProcessMigrationsStartForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsStartForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start a user migration<br/>
        /// Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Migration> MigrationsStartForAuthenticatedUserAsync(
            global::G.MigrationsStartForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareMigrationsStartForAuthenticatedUserArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/user/migrations", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMigrationsStartForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessMigrationsStartForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMigrationsStartForAuthenticatedUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Migration?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Start a user migration<br/>
        /// Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="lockRepositories">
        /// Lock the repositories being migrated at the start of the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata">
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeGitData">
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeAttachments">
        /// Do not include attachments in the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeReleases">
        /// Do not include releases in the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeOwnerProjects">
        /// Indicates whether projects owned by the organization or users should be excluded.<br/>
        /// Example: true
        /// </param>
        /// <param name="orgMetadataOnly">
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="exclude">
        /// Exclude attributes from the API response to improve performance<br/>
        /// Example: [repositories]
        /// </param>
        /// <param name="repositories"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Migration> MigrationsStartForAuthenticatedUserAsync(
            global::System.Collections.Generic.IList<string> repositories,
            bool lockRepositories = default,
            bool excludeMetadata = default,
            bool excludeGitData = default,
            bool excludeAttachments = default,
            bool excludeReleases = default,
            bool excludeOwnerProjects = default,
            bool orgMetadataOnly = false,
            global::System.Collections.Generic.IList<global::G.MigrationsStartForAuthenticatedUserRequestExcludeItem>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.MigrationsStartForAuthenticatedUserRequest
            {
                LockRepositories = lockRepositories,
                ExcludeMetadata = excludeMetadata,
                ExcludeGitData = excludeGitData,
                ExcludeAttachments = excludeAttachments,
                ExcludeReleases = excludeReleases,
                ExcludeOwnerProjects = excludeOwnerProjects,
                OrgMetadataOnly = orgMetadataOnly,
                Exclude = exclude,
                Repositories = repositories,
            };

            return await MigrationsStartForAuthenticatedUserAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}