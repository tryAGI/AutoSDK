//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        BLANK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}