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

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/user/migrations", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Migration?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Start a user migration<br/>
        /// Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="lockRepositories"></param>
        /// <param name="excludeMetadata"></param>
        /// <param name="excludeGitData"></param>
        /// <param name="excludeAttachments"></param>
        /// <param name="excludeReleases"></param>
        /// <param name="excludeOwnerProjects"></param>
        /// <param name="orgMetadataOnly"></param>
        /// <param name="exclude"></param>
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
            global::System.Collections.Generic.IList<global::G.MigrationsStartForAuthenticatedUserRequestExclude?>? exclude = default,
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