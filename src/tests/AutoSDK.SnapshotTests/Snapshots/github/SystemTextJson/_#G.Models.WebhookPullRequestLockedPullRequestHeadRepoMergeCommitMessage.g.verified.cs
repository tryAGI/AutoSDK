//HintName: G.Models.WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage
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
    public static class WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage.PrTitle,
                "BLANK" => WebhookPullRequestLockedPullRequestHeadRepoMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}