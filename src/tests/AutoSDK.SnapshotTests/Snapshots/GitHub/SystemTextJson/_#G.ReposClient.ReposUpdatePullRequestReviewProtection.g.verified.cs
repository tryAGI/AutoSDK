//HintName: G.ReposClient.ReposUpdatePullRequestReviewProtection.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposUpdatePullRequestReviewProtectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string branch,
            global::G.ReposUpdatePullRequestReviewProtectionRequest request);
        partial void PrepareReposUpdatePullRequestReviewProtectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string branch,
            global::G.ReposUpdatePullRequestReviewProtectionRequest request);
        partial void ProcessReposUpdatePullRequestReviewProtectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdatePullRequestReviewProtectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update pull request review protection<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Updating pull request review enforcement requires admin or owner permissions to the repository and branch protection to be enabled.<br/>
        /// **Note**: Passing new arrays of `users` and `teams` replaces their previous values.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProtectedBranchPullRequestReview> ReposUpdatePullRequestReviewProtectionAsync(
            string owner,
            string repo,
            string branch,
            global::G.ReposUpdatePullRequestReviewProtectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposUpdatePullRequestReviewProtectionArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                branch: ref branch,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposUpdatePullRequestReviewProtectionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                branch: branch,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposUpdatePullRequestReviewProtectionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposUpdatePullRequestReviewProtectionResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProtectedBranchPullRequestReview?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update pull request review protection<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Updating pull request review enforcement requires admin or owner permissions to the repository and branch protection to be enabled.<br/>
        /// **Note**: Passing new arrays of `users` and `teams` replaces their previous values.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="dismissalRestrictions">
        /// Specify which users, teams, and apps can dismiss pull request reviews. Pass an empty `dismissal_restrictions` object to disable. User and team `dismissal_restrictions` are only available for organization-owned repositories. Omit this parameter for personal repositories.
        /// </param>
        /// <param name="dismissStaleReviews">
        /// Set to `true` if you want to automatically dismiss approving reviews when someone pushes a new commit.
        /// </param>
        /// <param name="requireCodeOwnerReviews">
        /// Blocks merging pull requests until [code owners](https://docs.github.com/articles/about-code-owners/) have reviewed.
        /// </param>
        /// <param name="requiredApprovingReviewCount">
        /// Specifies the number of reviewers required to approve pull requests. Use a number between 1 and 6 or 0 to not require reviewers.
        /// </param>
        /// <param name="requireLastPushApproval">
        /// Whether the most recent push must be approved by someone other than the person who pushed it. Default: `false`<br/>
        /// Default Value: false
        /// </param>
        /// <param name="bypassPullRequestAllowances">
        /// Allow specific users, teams, or apps to bypass pull request requirements.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ProtectedBranchPullRequestReview> ReposUpdatePullRequestReviewProtectionAsync(
            string owner,
            string repo,
            string branch,
            global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions? dismissalRestrictions = default,
            bool dismissStaleReviews = default,
            bool requireCodeOwnerReviews = default,
            int requiredApprovingReviewCount = default,
            bool requireLastPushApproval = false,
            global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances? bypassPullRequestAllowances = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposUpdatePullRequestReviewProtectionRequest
            {
                DismissalRestrictions = dismissalRestrictions,
                DismissStaleReviews = dismissStaleReviews,
                RequireCodeOwnerReviews = requireCodeOwnerReviews,
                RequiredApprovingReviewCount = requiredApprovingReviewCount,
                RequireLastPushApproval = requireLastPushApproval,
                BypassPullRequestAllowances = bypassPullRequestAllowances,
            };

            return await ReposUpdatePullRequestReviewProtectionAsync(
                owner: owner,
                repo: repo,
                branch: branch,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}