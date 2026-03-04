//HintName: G.Models.NullableRepositorySquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum NullableRepositorySquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        CommitMessages,
        /// <summary>
        /// 
        /// </summary>
        Blank,
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
                NullableRepositorySquashMergeCommitMessage.PrBody => "PR_BODY",
                NullableRepositorySquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                NullableRepositorySquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositorySquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => NullableRepositorySquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => NullableRepositorySquashMergeCommitMessage.CommitMessages,
                "BLANK" => NullableRepositorySquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}