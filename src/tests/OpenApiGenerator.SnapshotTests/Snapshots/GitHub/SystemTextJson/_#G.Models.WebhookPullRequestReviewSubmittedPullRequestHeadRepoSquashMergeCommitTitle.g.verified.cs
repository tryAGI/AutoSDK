//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public abstract class WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        public const string PRTITLE = "PR_TITLE";
        /// <summary>
        /// 
        /// </summary>
        public const string COMMITORPRTITLE = "COMMIT_OR_PR_TITLE";
    }
}