//HintName: G.ReposClient.ReposUpdate.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FullRepository> ReposUpdateAsync(
            string owner,
            string repo,
            ReposUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}", global::System.UriKind.RelativeOrAbsolute));
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
        /// Update a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="homepage"></param>
        /// <param name="@private"></param>
        /// <param name="visibility"></param>
        /// <param name="securityAndAnalysis"></param>
        /// <param name="hasIssues"></param>
        /// <param name="hasProjects"></param>
        /// <param name="hasWiki"></param>
        /// <param name="isTemplate"></param>
        /// <param name="defaultBranch"></param>
        /// <param name="allowSquashMerge"></param>
        /// <param name="allowMergeCommit"></param>
        /// <param name="allowRebaseMerge"></param>
        /// <param name="allowAutoMerge"></param>
        /// <param name="deleteBranchOnMerge"></param>
        /// <param name="allowUpdateBranch"></param>
        /// <param name="useSquashPrTitleAsDefault"></param>
        /// <param name="squashMergeCommitTitle"></param>
        /// <param name="squashMergeCommitMessage"></param>
        /// <param name="mergeCommitTitle"></param>
        /// <param name="mergeCommitMessage"></param>
        /// <param name="archived"></param>
        /// <param name="allowForking"></param>
        /// <param name="webCommitSignoffRequired"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FullRepository> ReposUpdateAsync(
            string owner,
            string repo,
            string? name = default,
            string? description = default,
            string? homepage = default,
            bool @private = false,
            ReposUpdateRequestVisibility? visibility = default,
            ReposUpdateRequestSecurityAndAnalysis? securityAndAnalysis = default,
            bool hasIssues = true,
            bool hasProjects = true,
            bool hasWiki = true,
            bool isTemplate = false,
            string? defaultBranch = default,
            bool allowSquashMerge = true,
            bool allowMergeCommit = true,
            bool allowRebaseMerge = true,
            bool allowAutoMerge = false,
            bool deleteBranchOnMerge = false,
            bool allowUpdateBranch = false,
            bool useSquashPrTitleAsDefault = false,
            ReposUpdateRequestSquashMergeCommitTitle? squashMergeCommitTitle = default,
            ReposUpdateRequestSquashMergeCommitMessage? squashMergeCommitMessage = default,
            ReposUpdateRequestMergeCommitTitle? mergeCommitTitle = default,
            ReposUpdateRequestMergeCommitMessage? mergeCommitMessage = default,
            bool archived = false,
            bool allowForking = false,
            bool webCommitSignoffRequired = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateRequest
            {
                Name = name,
                Description = description,
                Homepage = homepage,
                Private = @private,
                Visibility = visibility,
                SecurityAndAnalysis = securityAndAnalysis,
                HasIssues = hasIssues,
                HasProjects = hasProjects,
                HasWiki = hasWiki,
                IsTemplate = isTemplate,
                DefaultBranch = defaultBranch,
                AllowSquashMerge = allowSquashMerge,
                AllowMergeCommit = allowMergeCommit,
                AllowRebaseMerge = allowRebaseMerge,
                AllowAutoMerge = allowAutoMerge,
                DeleteBranchOnMerge = deleteBranchOnMerge,
                AllowUpdateBranch = allowUpdateBranch,
                UseSquashPrTitleAsDefault = useSquashPrTitleAsDefault,
                SquashMergeCommitTitle = squashMergeCommitTitle,
                SquashMergeCommitMessage = squashMergeCommitMessage,
                MergeCommitTitle = mergeCommitTitle,
                MergeCommitMessage = mergeCommitMessage,
                Archived = archived,
                AllowForking = allowForking,
                WebCommitSignoffRequired = webCommitSignoffRequired,
            };

            return await ReposUpdateAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}