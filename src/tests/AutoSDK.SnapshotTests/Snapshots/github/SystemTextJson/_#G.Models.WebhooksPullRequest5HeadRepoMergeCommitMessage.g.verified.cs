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
        Blank,
        /// <summary>
        /// 
        /// </summary>
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        PrTitle,
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
                WebhooksPullRequest5HeadRepoMergeCommitMessage.Blank => "BLANK",
                WebhooksPullRequest5HeadRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhooksPullRequest5HeadRepoMergeCommitMessage.PrTitle => "PR_TITLE",
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
                "BLANK" => WebhooksPullRequest5HeadRepoMergeCommitMessage.Blank,
                "PR_BODY" => WebhooksPullRequest5HeadRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhooksPullRequest5HeadRepoMergeCommitMessage.PrTitle,
                _ => null,
            };
        }
    }
}