//HintName: G.Models.RepositorySquashMergeCommitTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit title:
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull request's title (when more than one commit).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositorySquashMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMMIT_OR_PR_TITLE")]
        COMMITORPRTITLE,
    }

    public static class RepositorySquashMergeCommitTitleExtensions
    {
        public static string ToValueString(this RepositorySquashMergeCommitTitle value)
        {
            return value switch
            {
                RepositorySquashMergeCommitTitle.PRTITLE => "PR_TITLE",
                RepositorySquashMergeCommitTitle.COMMITORPRTITLE => "COMMIT_OR_PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RepositorySquashMergeCommitTitle ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => RepositorySquashMergeCommitTitle.PRTITLE,
                "COMMIT_OR_PR_TITLE" => RepositorySquashMergeCommitTitle.COMMITORPRTITLE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RepositorySquashMergeCommitTitle ToEnum(int value)
        {
            return value switch
            {
                0 => RepositorySquashMergeCommitTitle.PRTITLE,
                1 => RepositorySquashMergeCommitTitle.COMMITORPRTITLE,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}