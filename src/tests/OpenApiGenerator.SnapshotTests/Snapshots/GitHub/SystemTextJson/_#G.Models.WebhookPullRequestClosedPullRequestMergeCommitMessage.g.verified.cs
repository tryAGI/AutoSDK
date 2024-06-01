//HintName: G.Models.WebhookPullRequestClosedPullRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestClosedPullRequestMergeCommitMessage
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
    public static class WebhookPullRequestClosedPullRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestClosedPullRequestMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestClosedPullRequestMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestClosedPullRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestClosedPullRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestClosedPullRequestMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestClosedPullRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestClosedPullRequestMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestClosedPullRequestMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}