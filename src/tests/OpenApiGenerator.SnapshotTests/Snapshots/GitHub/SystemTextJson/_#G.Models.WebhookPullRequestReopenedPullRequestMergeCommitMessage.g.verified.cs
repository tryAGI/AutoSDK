//HintName: G.Models.WebhookPullRequestReopenedPullRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReopenedPullRequestMergeCommitMessage
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
    public static class WebhookPullRequestReopenedPullRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReopenedPullRequestMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReopenedPullRequestMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReopenedPullRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestReopenedPullRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReopenedPullRequestMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReopenedPullRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestReopenedPullRequestMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestReopenedPullRequestMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}