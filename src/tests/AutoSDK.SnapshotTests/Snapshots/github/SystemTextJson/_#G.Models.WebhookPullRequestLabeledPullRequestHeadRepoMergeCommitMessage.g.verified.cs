//HintName: G.Models.WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage
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
    public static class WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage.PrTitle,
                "BLANK" => WebhookPullRequestLabeledPullRequestHeadRepoMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}