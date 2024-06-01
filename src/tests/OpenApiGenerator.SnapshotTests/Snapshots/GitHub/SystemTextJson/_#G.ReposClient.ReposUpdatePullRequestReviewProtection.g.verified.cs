//HintName: G.ReposClient.ReposUpdatePullRequestReviewProtection.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update pull request review protection
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ProtectedBranchPullRequestReview> ReposUpdatePullRequestReviewProtectionAsync(
            string owner,
            string repo,
            string branch,
            ReposUpdatePullRequestReviewProtectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/branches/{branch}/protection/required_pull_request_reviews", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<ProtectedBranchPullRequestReview?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update pull request review protection
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="dismissalRestrictions"></param>
        /// <param name="dismissStaleReviews"></param>
        /// <param name="requireCodeOwnerReviews"></param>
        /// <param name="requiredApprovingReviewCount"></param>
        /// <param name="requireLastPushApproval"></param>
        /// <param name="bypassPullRequestAllowances"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ProtectedBranchPullRequestReview> ReposUpdatePullRequestReviewProtectionAsync(
            string owner,
            string repo,
            string branch,
            ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions? dismissalRestrictions = default,
            bool dismissStaleReviews = default,
            bool requireCodeOwnerReviews = default,
            int requiredApprovingReviewCount = default,
            bool requireLastPushApproval = false,
            ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances? bypassPullRequestAllowances = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdatePullRequestReviewProtectionRequest
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