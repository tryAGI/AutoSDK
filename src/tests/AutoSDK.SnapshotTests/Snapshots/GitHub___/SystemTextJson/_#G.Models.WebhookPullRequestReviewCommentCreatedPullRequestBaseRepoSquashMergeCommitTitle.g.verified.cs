//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitle
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => WebhookPullRequestReviewCommentCreatedPullRequestBaseRepoSquashMergeCommitTitle.COMMITORPRTITLE,
                _ => null,
            };
        }
    }
}