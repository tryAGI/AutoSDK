//HintName: G.Models.PullRequestWebhookVariant2MergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum PullRequestWebhookVariant2MergeCommitMessage
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
    public static class PullRequestWebhookVariant2MergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestWebhookVariant2MergeCommitMessage value)
        {
            return value switch
            {
                PullRequestWebhookVariant2MergeCommitMessage.PrBody => "PR_BODY",
                PullRequestWebhookVariant2MergeCommitMessage.PrTitle => "PR_TITLE",
                PullRequestWebhookVariant2MergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestWebhookVariant2MergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => PullRequestWebhookVariant2MergeCommitMessage.PrBody,
                "PR_TITLE" => PullRequestWebhookVariant2MergeCommitMessage.PrTitle,
                "BLANK" => PullRequestWebhookVariant2MergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}