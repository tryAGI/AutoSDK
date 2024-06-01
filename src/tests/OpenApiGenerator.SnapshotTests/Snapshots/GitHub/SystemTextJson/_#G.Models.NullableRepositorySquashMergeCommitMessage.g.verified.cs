//HintName: G.Models.NullableRepositorySquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum NullableRepositorySquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        COMMITMESSAGES,
        /// <summary>
        /// 
        /// </summary>
        BLANK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableRepositorySquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableRepositorySquashMergeCommitMessage value)
        {
            return value switch
            {
                NullableRepositorySquashMergeCommitMessage.PRBODY => "PR_BODY",
                NullableRepositorySquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                NullableRepositorySquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositorySquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => NullableRepositorySquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => NullableRepositorySquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => NullableRepositorySquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}