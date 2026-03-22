//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        CommitOrPrTitle,
        /// <summary>
        /// 
        /// </summary>
        PrTitle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitle.CommitOrPrTitle => "COMMIT_OR_PR_TITLE",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitle.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "COMMIT_OR_PR_TITLE" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitle.CommitOrPrTitle,
                "PR_TITLE" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestBaseRepoSquashMergeCommitTitle.PrTitle,
                _ => null,
            };
        }
    }
}