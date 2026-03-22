//HintName: G.Models.PullRequestWebhookVariant2SquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public enum PullRequestWebhookVariant2SquashMergeCommitTitle
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
    public static class PullRequestWebhookVariant2SquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestWebhookVariant2SquashMergeCommitTitle value)
        {
            return value switch
            {
                PullRequestWebhookVariant2SquashMergeCommitTitle.CommitOrPrTitle => "COMMIT_OR_PR_TITLE",
                PullRequestWebhookVariant2SquashMergeCommitTitle.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestWebhookVariant2SquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "COMMIT_OR_PR_TITLE" => PullRequestWebhookVariant2SquashMergeCommitTitle.CommitOrPrTitle,
                "PR_TITLE" => PullRequestWebhookVariant2SquashMergeCommitTitle.PrTitle,
                _ => null,
            };
        }
    }
}