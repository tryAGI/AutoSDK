//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}