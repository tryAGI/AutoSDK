//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PrTitle,
        /// <summary>
        /// 
        /// </summary>
        CommitOrPrTitle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitle.PrTitle => "PR_TITLE",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitle.CommitOrPrTitle => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitle.PrTitle,
                "COMMIT_OR_PR_TITLE" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoSquashMergeCommitTitle.CommitOrPrTitle,
                _ => null,
            };
        }
    }
}