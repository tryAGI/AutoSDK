//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        COMMITORPRTITLE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseRepoSquashMergeCommitTitle.COMMITORPRTITLE,
                _ => null,
            };
        }
    }
}