//HintName: G.Models.ReposUpdateRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum ReposUpdateRequestMergeCommitMessage
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRequestMergeCommitMessage value)
        {
            return value switch
            {
                ReposUpdateRequestMergeCommitMessage.PRBODY => "PR_BODY",
                ReposUpdateRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                ReposUpdateRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRequestMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => ReposUpdateRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => ReposUpdateRequestMergeCommitMessage.PRTITLE,
                "BLANK" => ReposUpdateRequestMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}