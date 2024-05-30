//HintName: G.Models.RepositorySquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositorySquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_BODY")]
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMMIT_MESSAGES")]
        COMMITMESSAGES,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLANK")]
        BLANK,
    }

    public static class RepositorySquashMergeCommitMessageExtensions
    {
        public static string ToValueString(this RepositorySquashMergeCommitMessage value)
        {
            return value switch
            {
                RepositorySquashMergeCommitMessage.PRBODY => "PR_BODY",
                RepositorySquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                RepositorySquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RepositorySquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => RepositorySquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => RepositorySquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => RepositorySquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RepositorySquashMergeCommitMessage ToEnum(int value)
        {
            return value switch
            {
                0 => RepositorySquashMergeCommitMessage.PRBODY,
                1 => RepositorySquashMergeCommitMessage.COMMITMESSAGES,
                2 => RepositorySquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}