//HintName: G.ReposClient.ReposCreateInOrg.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.ReposCreateInOrgRequest request);
        partial void PrepareReposCreateInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.ReposCreateInOrgRequest request);
        partial void ProcessReposCreateInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateInOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an organization repository<br/>
        /// Creates a new repository in the specified organization. The authenticated user must be a member of the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateInOrgAsync(
            string org,
            global::G.ReposCreateInOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateInOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/repos",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateInOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposCreateInOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateInOrgResponseContent(
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
                global::G.FullRepository.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an organization repository<br/>
        /// Creates a new repository in the specified organization. The authenticated user must be a member of the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.
        /// </summary>
        /// <param name="org"></param>
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
        /// Whether the repository is private.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visibility">
        /// The visibility of the repository.
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
        /// <param name="hasDownloads">
        /// Whether downloads are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="isTemplate">
        /// Either `true` to make this repo available as a template repository or `false` to prevent it.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="teamId">
        /// The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
        /// </param>
        /// <param name="autoInit">
        /// Pass `true` to create an initial commit with empty README.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="gitignoreTemplate">
        /// Desired language or platform [.gitignore template](https://github.com/github/gitignore) to apply. Use the name of the template without the extension. For example, "Haskell".
        /// </param>
        /// <param name="licenseTemplate">
        /// Choose an [open source license template](https://choosealicense.com/) that best suits your needs, and then use the [license keyword](https://docs.github.com/articles/licensing-a-repository/#searching-github-by-license-type) as the `license_template` string. For example, "mit" or "mpl-2.0".
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
        /// Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion. **The authenticated user must be an organization owner to set this property to `true`.**<br/>
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
        /// <param name="customProperties">
        /// The custom properties for the new repository. The keys are the custom property names, and the values are the corresponding custom property values.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateInOrgAsync(
            string org,
            string name,
            string? description = default,
            string? homepage = default,
            bool? @private = false,
            global::G.ReposCreateInOrgRequestVisibility? visibility = default,
            bool? hasIssues = true,
            bool? hasProjects = true,
            bool? hasWiki = true,
            bool? hasDownloads = true,
            bool? isTemplate = false,
            int? teamId = default,
            bool? autoInit = false,
            string? gitignoreTemplate = default,
            string? licenseTemplate = default,
            bool? allowSquashMerge = true,
            bool? allowMergeCommit = true,
            bool? allowRebaseMerge = true,
            bool? allowAutoMerge = false,
            bool? deleteBranchOnMerge = false,
            global::G.ReposCreateInOrgRequestSquashMergeCommitTitle? squashMergeCommitTitle = default,
            global::G.ReposCreateInOrgRequestSquashMergeCommitMessage? squashMergeCommitMessage = default,
            global::G.ReposCreateInOrgRequestMergeCommitTitle? mergeCommitTitle = default,
            global::G.ReposCreateInOrgRequestMergeCommitMessage? mergeCommitMessage = default,
            object? customProperties = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateInOrgRequest
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