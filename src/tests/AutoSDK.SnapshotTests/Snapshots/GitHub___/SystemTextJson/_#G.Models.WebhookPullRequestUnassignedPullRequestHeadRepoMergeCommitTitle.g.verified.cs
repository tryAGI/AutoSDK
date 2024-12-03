//HintName: G.Models.WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitle
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
    public static class WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitle value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitle.PRTITLE => "PR_TITLE",
                WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}