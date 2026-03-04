//HintName: G.Models.WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage
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
    public static class WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage.PrTitle,
                "BLANK" => WebhookPullRequestLabeledPullRequestBaseRepoMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}