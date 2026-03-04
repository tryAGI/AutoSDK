//HintName: G.Models.ReposUpdateRequestSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum ReposUpdateRequestSquashMergeCommitMessage
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
    public static class ReposUpdateRequestSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRequestSquashMergeCommitMessage value)
        {
            return value switch
            {
                ReposUpdateRequestSquashMergeCommitMessage.PrBody => "PR_BODY",
                ReposUpdateRequestSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                ReposUpdateRequestSquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRequestSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => ReposUpdateRequestSquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => ReposUpdateRequestSquashMergeCommitMessage.CommitMessages,
                "BLANK" => ReposUpdateRequestSquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}