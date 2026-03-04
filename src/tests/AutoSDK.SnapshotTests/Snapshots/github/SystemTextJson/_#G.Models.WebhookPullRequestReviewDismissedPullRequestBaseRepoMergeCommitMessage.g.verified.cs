//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        PrTitle,
        /// <summary>
        /// 
        /// </summary>
        Blank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage.PrTitle,
                "BLANK" => WebhookPullRequestReviewDismissedPullRequestBaseRepoMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}