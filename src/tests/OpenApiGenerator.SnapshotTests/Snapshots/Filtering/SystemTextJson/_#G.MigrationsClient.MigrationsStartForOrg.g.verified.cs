//HintName: G.MigrationsClient.MigrationsStartForOrg.g.cs

#nullable enable

namespace G
{
    public partial class MigrationsClient
    {
        /// <summary>
        /// Start an organization migration<br/>
        /// Initiates the generation of a migration archive.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Migration> MigrationsStartForOrgAsync(
            string org,
            global::G.MigrationsStartForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/migrations", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Migration?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Start an organization migration<br/>
        /// Initiates the generation of a migration archive.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositories"></param>
        /// <param name="lockRepositories"></param>
        /// <param name="excludeMetadata"></param>
        /// <param name="excludeGitData"></param>
        /// <param name="excludeAttachments"></param>
        /// <param name="excludeReleases"></param>
        /// <param name="excludeOwnerProjects"></param>
        /// <param name="orgMetadataOnly"></param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Migration> MigrationsStartForOrgAsync(
            string org,
            global::System.Collections.Generic.IList<string> repositories,
            bool lockRepositories = false,
            bool excludeMetadata = false,
            bool excludeGitData = false,
            bool excludeAttachments = false,
            bool excludeReleases = false,
            bool excludeOwnerProjects = false,
            bool orgMetadataOnly = false,
            global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExclude?>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.MigrationsStartForOrgRequest
            {
                Repositories = repositories,
                LockRepositories = lockRepositories,
                ExcludeMetadata = excludeMetadata,
                ExcludeGitData = excludeGitData,
                ExcludeAttachments = excludeAttachments,
                ExcludeReleases = excludeReleases,
                ExcludeOwnerProjects = excludeOwnerProjects,
                OrgMetadataOnly = orgMetadataOnly,
                Exclude = exclude,
            };

            return await MigrationsStartForOrgAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}