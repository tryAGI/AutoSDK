//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => WebhookPullRequestReviewCommentDeletedPullRequestHeadRepoSquashMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}