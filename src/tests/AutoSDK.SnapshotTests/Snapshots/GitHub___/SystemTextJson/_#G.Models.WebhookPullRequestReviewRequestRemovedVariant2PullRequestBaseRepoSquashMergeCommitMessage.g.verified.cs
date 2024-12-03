//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestBaseRepoSquashMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}