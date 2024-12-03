//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => WebhookPullRequestReviewCommentEditedPullRequestHeadRepoSquashMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}