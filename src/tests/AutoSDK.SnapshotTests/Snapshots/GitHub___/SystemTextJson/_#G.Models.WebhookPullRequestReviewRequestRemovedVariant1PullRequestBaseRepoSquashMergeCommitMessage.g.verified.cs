//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}