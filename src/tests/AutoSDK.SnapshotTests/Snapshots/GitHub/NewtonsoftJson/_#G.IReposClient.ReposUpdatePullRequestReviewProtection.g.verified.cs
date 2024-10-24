//HintName: G.IReposClient.ReposUpdatePullRequestReviewProtection.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Update pull request review protection<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Updating pull request review enforcement requires admin or owner permissions to the repository and branch protection to be enabled.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Passing new arrays of `users` and `teams` replaces their previous values.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProtectedBranchPullRequestReview> ReposUpdatePullRequestReviewProtectionAsync(
            string owner,
            string repo,
            string branch,
            global::G.ReposUpdatePullRequestReviewProtectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update pull request review protection<br/>
        /// Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.<br/>
        /// Updating pull request review enforcement requires admin or owner permissions to the repository and branch protection to be enabled.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Passing new arrays of `users` and `teams` replaces their previous values.
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
        global::System.Threading.Tasks.Task<global::G.ProtectedBranchPullRequestReview> ReposUpdatePullRequestReviewProtectionAsync(
            string owner,
            string repo,
            string branch,
            global::G.ReposUpdatePullRequestReviewProtectionRequestDismissalRestrictions? dismissalRestrictions = default,
            bool? dismissStaleReviews = default,
            bool? requireCodeOwnerReviews = default,
            int? requiredApprovingReviewCount = default,
            bool? requireLastPushApproval = default,
            global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances? bypassPullRequestAllowances = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}