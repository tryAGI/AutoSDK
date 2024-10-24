//HintName: G.ReposClient.ReposCreateForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.ReposCreateForAuthenticatedUserRequest request);
        partial void PrepareReposCreateForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.ReposCreateForAuthenticatedUserRequest request);
        partial void ProcessReposCreateForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a repository for the authenticated user<br/>
        /// Creates a new repository for the authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateForAuthenticatedUserAsync(
            global::G.ReposCreateForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReposCreateForAuthenticatedUserArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/user/repos",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposCreateForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposCreateForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposCreateForAuthenticatedUserResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.FullRepository.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a repository for the authenticated user<br/>
        /// Creates a new repository for the authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.
        /// </summary>
        /// <param name="name">
        /// The name of the repository.<br/>
        /// Example: Team Environment
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
        /// <param name="hasIssues">
        /// Whether issues are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="hasProjects">
        /// Whether projects are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="hasWiki">
        /// Whether the wiki is enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="hasDiscussions">
        /// Whether discussions are enabled.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="teamId">
        /// The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
        /// </param>
        /// <param name="autoInit">
        /// Whether the repository is initialized with a minimal README.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="gitignoreTemplate">
        /// The desired language or platform to apply to the .gitignore.<br/>
        /// Example: Haskell
        /// </param>
        /// <param name="licenseTemplate">
        /// The license keyword of the open source license for this repository.<br/>
        /// Example: mit
        /// </param>
        /// <param name="allowSquashMerge">
        /// Whether to allow squash merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="allowMergeCommit">
        /// Whether to allow merge commits for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="allowRebaseMerge">
        /// Whether to allow rebase merges for pull requests.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="allowAutoMerge">
        /// Whether to allow Auto-merge to be used on pull requests.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="deleteBranchOnMerge">
        /// Whether to delete head branches when pull requests are merged<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="squashMergeCommitTitle">
        /// Required when using `squash_merge_commit_message`.<br/>
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
        /// Required when using `merge_commit_message`.<br/>
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
        /// <param name="hasDownloads">
        /// Whether downloads are enabled.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="isTemplate">
        /// Whether this repository acts as a template that can be used to generate new repositories.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateForAuthenticatedUserAsync(
            string name,
            string? description = default,
            string? homepage = default,
            bool? @private = default,
            bool? hasIssues = default,
            bool? hasProjects = default,
            bool? hasWiki = default,
            bool? hasDiscussions = default,
            int? teamId = default,
            bool? autoInit = default,
            string? gitignoreTemplate = default,
            string? licenseTemplate = default,
            bool? allowSquashMerge = default,
            bool? allowMergeCommit = default,
            bool? allowRebaseMerge = default,
            bool? allowAutoMerge = default,
            bool? deleteBranchOnMerge = default,
            global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitle? squashMergeCommitTitle = default,
            global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage? squashMergeCommitMessage = default,
            global::G.ReposCreateForAuthenticatedUserRequestMergeCommitTitle? mergeCommitTitle = default,
            global::G.ReposCreateForAuthenticatedUserRequestMergeCommitMessage? mergeCommitMessage = default,
            bool? hasDownloads = default,
            bool? isTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ReposCreateForAuthenticatedUserRequest
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
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}