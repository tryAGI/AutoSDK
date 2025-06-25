//HintName: G.Models.NullableRepositoryMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    public enum NullableRepositoryMergeCommitTitle
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
    public static class NullableRepositoryMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableRepositoryMergeCommitTitle value)
        {
            return value switch
            {
                NullableRepositoryMergeCommitTitle.PRTITLE => "PR_TITLE",
                NullableRepositoryMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositoryMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => NullableRepositoryMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => NullableRepositoryMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}