//HintName: G.ReposClient.ReposUpdate.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.ReposUpdateRequest request);
        partial void PrepareReposUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ReposUpdateRequest request);
        partial void ProcessReposUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a repository<br/>
        /// **Note**: To edit a repository's topics, use the [Replace all repository topics](https://docs.github.com/rest/repos/repos#replace-all-repository-topics) endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposUpdateAsync(
            string owner,
            string repo,
            global::G.ReposUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposUpdateArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposUpdateRequest(
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
            ProcessReposUpdateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposUpdateResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FullRepository?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a repository<br/>
        /// **Note**: To edit a repository's topics, use the [Replace all repository topics](https://docs.github.com/rest/repos/repos#replace-all-repository-topics) endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name">
        /// The name of the repository.
        /// </param>
        /// <param name="description">
        /// A short description of the repository.
        /// </param>
        /// <param name="homepage">
        /// A URL with more information about the repository.
        /// </param>
        /// <param name="private">
        /// Either `true` to make the repository private or `false` to make it public. Default: `false`.  <br/>
        /// **Note**: You will get a `422` error if the organization restricts [changing repository visibility](https://docs.github.com/articles/repository-permission-levels-for-an-organization#changing-the-visibility-of-repositories) to organization owners and a non-owner tries to change the value of private.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visibility">
        /// The visibility of the repository.
        /// </param>
        /// <param name="securityAndAnalysis">
        /// Specify which security and analysis features to enable or disable for the repository.<br/>
        /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// For example, to enable GitHub Advanced Security, use this data in the body of the `PATCH` request:<br/>
        /// `{ "security_and_analysis": {"advanced_security": { "status": "enabled" } } }`.<br/>
        /// You can check which security and analysis features are currently enabled by using a `GET /repos/{owner}/{repo}` request.
        /// </param>
        /// <param name="hasIssues">
        /// Either `true` to enable issues for this repository or `false` to disable them.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="hasProjects">
        /// Either `true` to enable projects for this repository or `false` to disable them. **Note:** If you're creating a repository in an organization that has disabled repository projects, the default is `false`, and if you pass `true`, the API returns an error.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="hasWiki">
        /// Either `true` to enable the wiki for this repository or `false` to disable it.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="isTemplate">
        /// Either `true` to make this repo available as a template repository or `false` to prevent it.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="defaultBranch">
        /// Updates the default branch for this repository.
        /// </param>
        /// <param name="allowSquashMerge">
        /// Either `true` to allow squash-merging pull requests, or `false` to prevent squash-merging.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowMergeCommit">
        /// Either `true` to allow merging pull requests with a merge commit, or `false` to prevent merging pull requests with merge commits.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowRebaseMerge">
        /// Either `true` to allow rebase-merging pull requests, or `false` to prevent rebase-merging.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowAutoMerge">
        /// Either `true` to allow auto-merge on pull requests, or `false` to disallow auto-merge.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="deleteBranchOnMerge">
        /// Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowUpdateBranch">
        /// Either `true` to always allow a pull request head branch that is behind its base branch to be updated even if it is not required to be up to date before merging, or false otherwise.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="squashMergeCommitTitle">
        /// The default value for a squash merge commit title:<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
        /// </param>
        /// <param name="squashMergeCommitMessage">
        /// The default value for a squash merge commit message:<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </param>
        /// <param name="mergeCommitTitle">
        /// The default value for a merge commit title.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
        /// </param>
        /// <param name="mergeCommitMessage">
        /// The default value for a merge commit message.<br/>
        /// - `PR_TITLE` - default to the pull request's title.<br/>
        /// - `PR_BODY` - default to the pull request's body.<br/>
        /// - `BLANK` - default to a blank commit message.
        /// </param>
        /// <param name="archived">
        /// Whether to archive this repository. `false` will unarchive a previously archived repository.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowForking">
        /// Either `true` to allow private forks, or `false` to prevent private forks.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webCommitSignoffRequired">
        /// Either `true` to require contributors to sign off on web-based commits, or `false` to not require contributors to sign off on web-based commits.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposUpdateAsync(
            string owner,
            string repo,
            string? name = default,
            string? description = default,
            string? homepage = default,
            bool @private = false,
            global::G.ReposUpdateRequestVisibility? visibility = default,
            global::G.ReposUpdateRequestSecurityAndAnalysis? securityAndAnalysis = default,
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
            global::G.ReposUpdateRequestSquashMergeCommitTitle? squashMergeCommitTitle = default,
            global::G.ReposUpdateRequestSquashMergeCommitMessage? squashMergeCommitMessage = default,
            global::G.ReposUpdateRequestMergeCommitTitle? mergeCommitTitle = default,
            global::G.ReposUpdateRequestMergeCommitMessage? mergeCommitMessage = default,
            bool archived = false,
            bool allowForking = false,
            bool webCommitSignoffRequired = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposUpdateRequest
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