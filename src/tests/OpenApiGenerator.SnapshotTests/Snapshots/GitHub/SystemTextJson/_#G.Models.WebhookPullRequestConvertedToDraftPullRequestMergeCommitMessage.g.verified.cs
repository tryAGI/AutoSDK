//HintName: G.Models.WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage
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
    public static class WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestConvertedToDraftPullRequestMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}