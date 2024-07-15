//HintName: G.Models.WebhookPullRequestOpenedPullRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestOpenedPullRequestMergeCommitMessage
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
    public static class WebhookPullRequestOpenedPullRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestOpenedPullRequestMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestOpenedPullRequestMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestOpenedPullRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestOpenedPullRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestOpenedPullRequestMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestOpenedPullRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestOpenedPullRequestMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestOpenedPullRequestMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}