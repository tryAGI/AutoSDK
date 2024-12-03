//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage
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
    public static class WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestEnqueuedPullRequestHeadRepoMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}