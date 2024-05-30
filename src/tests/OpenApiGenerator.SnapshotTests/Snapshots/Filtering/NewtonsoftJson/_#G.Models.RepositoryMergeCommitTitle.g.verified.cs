//HintName: G.Models.RepositoryMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit title.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MERGE_MESSAGE")]
        MERGEMESSAGE,
    }

    public static class RepositoryMergeCommitTitleExtensions
    {
        public static string ToValueString(this RepositoryMergeCommitTitle value)
        {
            return value switch
            {
                RepositoryMergeCommitTitle.PRTITLE => "PR_TITLE",
                RepositoryMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RepositoryMergeCommitTitle ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => RepositoryMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => RepositoryMergeCommitTitle.MERGEMESSAGE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RepositoryMergeCommitTitle ToEnum(int value)
        {
            return value switch
            {
                0 => RepositoryMergeCommitTitle.PRTITLE,
                1 => RepositoryMergeCommitTitle.MERGEMESSAGE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}