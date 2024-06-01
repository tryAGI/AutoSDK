//HintName: G.Models.RepositoryWebhooksSquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public enum RepositoryWebhooksSquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        COMMITORPRTITLE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryWebhooksSquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksSquashMergeCommitTitle value)
        {
            return value switch
            {
                RepositoryWebhooksSquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                RepositoryWebhooksSquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksSquashMergeCommitTitle ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => RepositoryWebhooksSquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => RepositoryWebhooksSquashMergeCommitTitle.COMMITORPRTITLE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}