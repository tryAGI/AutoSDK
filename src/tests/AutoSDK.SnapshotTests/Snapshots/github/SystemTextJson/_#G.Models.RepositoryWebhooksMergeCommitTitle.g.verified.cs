//HintName: G.Models.RepositoryWebhooksMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    public enum RepositoryWebhooksMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        MergeMessage,
        /// <summary>
        /// 
        /// </summary>
        PrTitle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryWebhooksMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksMergeCommitTitle value)
        {
            return value switch
            {
                RepositoryWebhooksMergeCommitTitle.MergeMessage => "MERGE_MESSAGE",
                RepositoryWebhooksMergeCommitTitle.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "MERGE_MESSAGE" => RepositoryWebhooksMergeCommitTitle.MergeMessage,
                "PR_TITLE" => RepositoryWebhooksMergeCommitTitle.PrTitle,
                _ => null,
            };
        }
    }
}