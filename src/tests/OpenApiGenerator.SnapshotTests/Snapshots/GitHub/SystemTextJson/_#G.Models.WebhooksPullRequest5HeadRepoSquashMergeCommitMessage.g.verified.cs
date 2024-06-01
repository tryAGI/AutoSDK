//HintName: G.Models.WebhooksPullRequest5HeadRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhooksPullRequest5HeadRepoSquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        COMMITMESSAGES,
        /// <summary>
        /// 
        /// </summary>
        BLANK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPullRequest5HeadRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5HeadRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhooksPullRequest5HeadRepoSquashMergeCommitMessage.PRBODY => "PR_BODY",
                WebhooksPullRequest5HeadRepoSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                WebhooksPullRequest5HeadRepoSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5HeadRepoSquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhooksPullRequest5HeadRepoSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => WebhooksPullRequest5HeadRepoSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => WebhooksPullRequest5HeadRepoSquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}