//HintName: G.Models.RepositoryMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum RepositoryMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        BLANK,
    }

    public static class RepositoryMergeCommitMessageExtensions
    {
        public static string ToValueString(this RepositoryMergeCommitMessage value)
        {
            return value switch
            {
                RepositoryMergeCommitMessage.PRBODY => "PR_BODY",
                RepositoryMergeCommitMessage.PRTITLE => "PR_TITLE",
                RepositoryMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RepositoryMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => RepositoryMergeCommitMessage.PRBODY,
                "PR_TITLE" => RepositoryMergeCommitMessage.PRTITLE,
                "BLANK" => RepositoryMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RepositoryMergeCommitMessage ToEnum(int value)
        {
            return value switch
            {
                0 => RepositoryMergeCommitMessage.PRBODY,
                1 => RepositoryMergeCommitMessage.PRTITLE,
                2 => RepositoryMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}