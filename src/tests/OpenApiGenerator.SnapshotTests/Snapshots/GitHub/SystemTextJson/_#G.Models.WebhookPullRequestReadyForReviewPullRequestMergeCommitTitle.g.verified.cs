//HintName: G.Models.WebhookPullRequestReadyForReviewPullRequestMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., "Merge pull request #123 from branch-name").
    /// </summary>
    public enum WebhookPullRequestReadyForReviewPullRequestMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        MERGEMESSAGE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReadyForReviewPullRequestMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReadyForReviewPullRequestMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestReadyForReviewPullRequestMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestReadyForReviewPullRequestMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReadyForReviewPullRequestMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestReadyForReviewPullRequestMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => WebhookPullRequestReadyForReviewPullRequestMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}