//HintName: G.Models.WebhooksPullRequest5BaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhooksPullRequest5BaseRepoMergeCommitMessage
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
    public static class WebhooksPullRequest5BaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5BaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhooksPullRequest5BaseRepoMergeCommitMessage.Blank => "BLANK",
                WebhooksPullRequest5BaseRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhooksPullRequest5BaseRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5BaseRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => WebhooksPullRequest5BaseRepoMergeCommitMessage.Blank,
                "PR_BODY" => WebhooksPullRequest5BaseRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhooksPullRequest5BaseRepoMergeCommitMessage.PrTitle,
                _ => null,
            };
        }
    }
}