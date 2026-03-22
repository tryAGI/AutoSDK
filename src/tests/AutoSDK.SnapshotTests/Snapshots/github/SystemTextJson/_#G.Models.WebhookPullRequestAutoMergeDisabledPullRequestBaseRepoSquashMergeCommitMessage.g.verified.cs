//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        CommitMessages,
        /// <summary>
        /// 
        /// </summary>
        PrBody,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage.Blank => "BLANK",
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage.PrBody => "PR_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage.Blank,
                "COMMIT_MESSAGES" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage.CommitMessages,
                "PR_BODY" => WebhookPullRequestAutoMergeDisabledPullRequestBaseRepoSquashMergeCommitMessage.PrBody,
                _ => null,
            };
        }
    }
}