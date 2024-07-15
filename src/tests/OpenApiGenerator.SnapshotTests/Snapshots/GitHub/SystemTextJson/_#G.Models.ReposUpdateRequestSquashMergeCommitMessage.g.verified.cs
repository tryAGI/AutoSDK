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
    public static class ReposUpdateRequestSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRequestSquashMergeCommitMessage value)
        {
            return value switch
            {
                ReposUpdateRequestSquashMergeCommitMessage.PRBODY => "PR_BODY",
                ReposUpdateRequestSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                ReposUpdateRequestSquashMergeCommitMessage.BLANK => "BLANK",
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
                "PR_BODY" => ReposUpdateRequestSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => ReposUpdateRequestSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => ReposUpdateRequestSquashMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}