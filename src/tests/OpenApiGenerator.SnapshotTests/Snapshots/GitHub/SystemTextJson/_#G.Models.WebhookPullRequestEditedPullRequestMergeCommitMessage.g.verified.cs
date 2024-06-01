//HintName: G.Models.WebhookPullRequestEditedPullRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestEditedPullRequestMergeCommitMessage
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
    public static class WebhookPullRequestEditedPullRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEditedPullRequestMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestEditedPullRequestMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestEditedPullRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestEditedPullRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEditedPullRequestMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestEditedPullRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestEditedPullRequestMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestEditedPullRequestMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}