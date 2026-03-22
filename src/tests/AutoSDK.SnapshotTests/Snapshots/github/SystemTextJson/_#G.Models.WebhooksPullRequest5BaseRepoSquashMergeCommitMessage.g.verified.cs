//HintName: G.Models.WebhooksPullRequest5BaseRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhooksPullRequest5BaseRepoSquashMergeCommitMessage
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
    public static class WebhooksPullRequest5BaseRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5BaseRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhooksPullRequest5BaseRepoSquashMergeCommitMessage.Blank => "BLANK",
                WebhooksPullRequest5BaseRepoSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                WebhooksPullRequest5BaseRepoSquashMergeCommitMessage.PrBody => "PR_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5BaseRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => WebhooksPullRequest5BaseRepoSquashMergeCommitMessage.Blank,
                "COMMIT_MESSAGES" => WebhooksPullRequest5BaseRepoSquashMergeCommitMessage.CommitMessages,
                "PR_BODY" => WebhooksPullRequest5BaseRepoSquashMergeCommitMessage.PrBody,
                _ => null,
            };
        }
    }
}