//HintName: G.ReposClient.ReposCreateForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a repository for the authenticated user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FullRepository> ReposCreateForAuthenticatedUserAsync(
            ReposCreateForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/user/repos", global::System.UriKind.RelativeOrAbsolute));
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
        /// Create a repository for the authenticated user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="homepage"></param>
        /// <param name="@private"></param>
        /// <param name="hasIssues"></param>
        /// <param name="hasProjects"></param>
        /// <param name="hasWiki"></param>
        /// <param name="hasDiscussions"></param>
        /// <param name="teamId"></param>
        /// <param name="autoInit"></param>
        /// <param name="gitignoreTemplate"></param>
        /// <param name="licenseTemplate"></param>
        /// <param name="allowSquashMerge"></param>
        /// <param name="allowMergeCommit"></param>
        /// <param name="allowRebaseMerge"></param>
        /// <param name="allowAutoMerge"></param>
        /// <param name="deleteBranchOnMerge"></param>
        /// <param name="squashMergeCommitTitle"></param>
        /// <param name="squashMergeCommitMessage"></param>
        /// <param name="mergeCommitTitle"></param>
        /// <param name="mergeCommitMessage"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="isTemplate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FullRepository> ReposCreateForAuthenticatedUserAsync(
            string name,
            string? description = default,
            string? homepage = default,
            bool @private = false,
            bool hasIssues = true,
            bool hasProjects = true,
            bool hasWiki = true,
            bool hasDiscussions = false,
            int teamId = default,
            bool autoInit = false,
            string? gitignoreTemplate = default,
            string? licenseTemplate = default,
            bool allowSquashMerge = true,
            bool allowMergeCommit = true,
            bool allowRebaseMerge = true,
            bool allowAutoMerge = false,
            bool deleteBranchOnMerge = false,
            ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitle? squashMergeCommitTitle = default,
            ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage? squashMergeCommitMessage = default,
            ReposCreateForAuthenticatedUserRequestMergeCommitTitle? mergeCommitTitle = default,
            ReposCreateForAuthenticatedUserRequestMergeCommitMessage? mergeCommitMessage = default,
            bool hasDownloads = true,
            bool isTemplate = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateForAuthenticatedUserRequest
            {
                Name = name,
                Description = description,
                Homepage = homepage,
                Private = @private,
                HasIssues = hasIssues,
                HasProjects = hasProjects,
                HasWiki = hasWiki,
                HasDiscussions = hasDiscussions,
                TeamId = teamId,
                AutoInit = autoInit,
                GitignoreTemplate = gitignoreTemplate,
                LicenseTemplate = licenseTemplate,
                AllowSquashMerge = allowSquashMerge,
                AllowMergeCommit = allowMergeCommit,
                AllowRebaseMerge = allowRebaseMerge,
                AllowAutoMerge = allowAutoMerge,
                DeleteBranchOnMerge = deleteBranchOnMerge,
                SquashMergeCommitTitle = squashMergeCommitTitle,
                SquashMergeCommitMessage = squashMergeCommitMessage,
                MergeCommitTitle = mergeCommitTitle,
                MergeCommitMessage = mergeCommitMessage,
                HasDownloads = hasDownloads,
                IsTemplate = isTemplate,
            };

            return await ReposCreateForAuthenticatedUserAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}