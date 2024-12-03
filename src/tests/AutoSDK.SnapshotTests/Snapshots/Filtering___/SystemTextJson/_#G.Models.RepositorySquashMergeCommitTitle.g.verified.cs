//HintName: G.Models.RepositorySquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    public enum RepositorySquashMergeCommitTitle
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
    public static class RepositorySquashMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositorySquashMergeCommitTitle value)
        {
            return value switch
            {
                RepositorySquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                RepositorySquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositorySquashMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => RepositorySquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => RepositorySquashMergeCommitTitle.COMMITORPRTITLE,
                _ => null,
            };
        }
    }
}