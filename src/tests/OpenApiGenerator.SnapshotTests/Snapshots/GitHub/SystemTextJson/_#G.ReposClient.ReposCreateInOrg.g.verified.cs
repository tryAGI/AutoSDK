//HintName: G.ReposClient.ReposCreateInOrg.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create an organization repository
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FullRepository> ReposCreateInOrgAsync(
            string org,
            ReposCreateInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/repos", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<FullRepository?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an organization repository
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="homepage"></param>
        /// <param name="@private"></param>
        /// <param name="visibility"></param>
        /// <param name="hasIssues"></param>
        /// <param name="hasProjects"></param>
        /// <param name="hasWiki"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="isTemplate"></param>
        /// <param name="teamId"></param>
        /// <param name="autoInit"></param>
        /// <param name="gitignoreTemplate"></param>
        /// <param name="licenseTemplate"></param>
        /// <param name="allowSquashMerge"></param>
        /// <param name="allowMergeCommit"></param>
        /// <param name="allowRebaseMerge"></param>
        /// <param name="allowAutoMerge"></param>
        /// <param name="deleteBranchOnMerge"></param>
        /// <param name="useSquashPrTitleAsDefault"></param>
        /// <param name="squashMergeCommitTitle"></param>
        /// <param name="squashMergeCommitMessage"></param>
        /// <param name="mergeCommitTitle"></param>
        /// <param name="mergeCommitMessage"></param>
        /// <param name="customProperties"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FullRepository> ReposCreateInOrgAsync(
            string org,
            string name,
            string? description = default,
            string? homepage = default,
            bool @private = false,
            ReposCreateInOrgRequestVisibility? visibility = default,
            bool hasIssues = true,
            bool hasProjects = true,
            bool hasWiki = true,
            bool hasDownloads = true,
            bool isTemplate = false,
            int teamId = default,
            bool autoInit = false,
            string? gitignoreTemplate = default,
            string? licenseTemplate = default,
            bool allowSquashMerge = true,
            bool allowMergeCommit = true,
            bool allowRebaseMerge = true,
            bool allowAutoMerge = false,
            bool deleteBranchOnMerge = false,
            bool useSquashPrTitleAsDefault = false,
            ReposCreateInOrgRequestSquashMergeCommitTitle? squashMergeCommitTitle = default,
            ReposCreateInOrgRequestSquashMergeCommitMessage? squashMergeCommitMessage = default,
            ReposCreateInOrgRequestMergeCommitTitle? mergeCommitTitle = default,
            ReposCreateInOrgRequestMergeCommitMessage? mergeCommitMessage = default,
            object? customProperties = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateInOrgRequest
            {
                Name = name,
                Description = description,
                Homepage = homepage,
                Private = @private,
                Visibility = visibility,
                HasIssues = hasIssues,
                HasProjects = hasProjects,
                HasWiki = hasWiki,
                HasDownloads = hasDownloads,
                IsTemplate = isTemplate,
                TeamId = teamId,
                AutoInit = autoInit,
                GitignoreTemplate = gitignoreTemplate,
                LicenseTemplate = licenseTemplate,
                AllowSquashMerge = allowSquashMerge,
                AllowMergeCommit = allowMergeCommit,
                AllowRebaseMerge = allowRebaseMerge,
                AllowAutoMerge = allowAutoMerge,
                DeleteBranchOnMerge = deleteBranchOnMerge,
                UseSquashPrTitleAsDefault = useSquashPrTitleAsDefault,
                SquashMergeCommitTitle = squashMergeCommitTitle,
                SquashMergeCommitMessage = squashMergeCommitMessage,
                MergeCommitTitle = mergeCommitTitle,
                MergeCommitMessage = mergeCommitMessage,
                CustomProperties = customProperties,
            };

            return await ReposCreateInOrgAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}