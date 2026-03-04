//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage
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
    public static class WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage.PrTitle,
                "BLANK" => WebhookPullRequestEnqueuedPullRequestBaseRepoMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}