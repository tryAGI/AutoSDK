//HintName: G.Models.WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage
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
    public static class WebhookPullRequestReadyForReviewPullRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestReadyForReviewPullRequestMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}