//HintName: G.Models.PullRequestWebhookVariant2MergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., "Merge pull request #123 from branch-name").
    /// </summary>
    public enum PullRequestWebhookVariant2MergeCommitTitle
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
    public static class PullRequestWebhookVariant2MergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestWebhookVariant2MergeCommitTitle value)
        {
            return value switch
            {
                PullRequestWebhookVariant2MergeCommitTitle.PRTITLE => "PR_TITLE",
                PullRequestWebhookVariant2MergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestWebhookVariant2MergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => PullRequestWebhookVariant2MergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => PullRequestWebhookVariant2MergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}