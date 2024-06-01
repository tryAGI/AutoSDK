//HintName: G.Models.WebhooksPullRequest5BaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhooksPullRequest5BaseRepoMergeCommitMessage
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
    public static class WebhooksPullRequest5BaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5BaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhooksPullRequest5BaseRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhooksPullRequest5BaseRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhooksPullRequest5BaseRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5BaseRepoMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhooksPullRequest5BaseRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhooksPullRequest5BaseRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhooksPullRequest5BaseRepoMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}