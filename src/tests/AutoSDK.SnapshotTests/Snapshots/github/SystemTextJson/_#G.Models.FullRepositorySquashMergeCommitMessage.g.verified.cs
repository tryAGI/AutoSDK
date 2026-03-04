//HintName: G.Models.FullRepositorySquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.<br/>
    /// Example: PR_BODY
    /// </summary>
    public enum FullRepositorySquashMergeCommitMessage
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
    public static class FullRepositorySquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FullRepositorySquashMergeCommitMessage value)
        {
            return value switch
            {
                FullRepositorySquashMergeCommitMessage.PrBody => "PR_BODY",
                FullRepositorySquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                FullRepositorySquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FullRepositorySquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => FullRepositorySquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => FullRepositorySquashMergeCommitMessage.CommitMessages,
                "BLANK" => FullRepositorySquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}