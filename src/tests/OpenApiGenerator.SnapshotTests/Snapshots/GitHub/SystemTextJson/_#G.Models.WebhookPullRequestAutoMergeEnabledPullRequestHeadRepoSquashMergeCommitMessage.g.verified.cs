//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => WebhookPullRequestAutoMergeEnabledPullRequestHeadRepoSquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}