//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.PrTitle,
                "BLANK" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}