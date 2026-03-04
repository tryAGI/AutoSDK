//HintName: G.Models.WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        CommitMessages,
        /// <summary>
        /// 
        /// </summary>
        Blank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage.CommitMessages,
                "BLANK" => WebhookPullRequestLockedPullRequestBaseRepoSquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}