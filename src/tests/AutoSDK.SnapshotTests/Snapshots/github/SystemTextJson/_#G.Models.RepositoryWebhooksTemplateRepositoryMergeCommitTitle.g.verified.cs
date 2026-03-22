//HintName: G.Models.RepositoryWebhooksTemplateRepositoryMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    public enum RepositoryWebhooksTemplateRepositoryMergeCommitTitle
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
    public static class RepositoryWebhooksTemplateRepositoryMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksTemplateRepositoryMergeCommitTitle value)
        {
            return value switch
            {
                RepositoryWebhooksTemplateRepositoryMergeCommitTitle.MergeMessage => "MERGE_MESSAGE",
                RepositoryWebhooksTemplateRepositoryMergeCommitTitle.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksTemplateRepositoryMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "MERGE_MESSAGE" => RepositoryWebhooksTemplateRepositoryMergeCommitTitle.MergeMessage,
                "PR_TITLE" => RepositoryWebhooksTemplateRepositoryMergeCommitTitle.PrTitle,
                _ => null,
            };
        }
    }
}