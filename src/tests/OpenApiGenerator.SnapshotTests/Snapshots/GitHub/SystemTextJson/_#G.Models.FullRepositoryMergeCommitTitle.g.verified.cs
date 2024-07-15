//HintName: G.Models.FullRepositoryMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    ///   - `PR_TITLE` - default to the pull request's title.<br/>
    ///   - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).<br/>
    /// Example: PR_TITLE
    /// </summary>
    public enum FullRepositoryMergeCommitTitle
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
    public static class FullRepositoryMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FullRepositoryMergeCommitTitle value)
        {
            return value switch
            {
                FullRepositoryMergeCommitTitle.PRTITLE => "PR_TITLE",
                FullRepositoryMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FullRepositoryMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => FullRepositoryMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => FullRepositoryMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}