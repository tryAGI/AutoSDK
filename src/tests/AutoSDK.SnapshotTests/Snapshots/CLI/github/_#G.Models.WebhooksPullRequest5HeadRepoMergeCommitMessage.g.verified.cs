//HintName: G.Models.WebhooksPullRequest5HeadRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhooksPullRequest5HeadRepoMergeCommitMessage
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
    public static class WebhooksPullRequest5HeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5HeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhooksPullRequest5HeadRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhooksPullRequest5HeadRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhooksPullRequest5HeadRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5HeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhooksPullRequest5HeadRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhooksPullRequest5HeadRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhooksPullRequest5HeadRepoMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}