//HintName: G.Models.ReposUpdateRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum ReposUpdateRequestMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        PrTitle,
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
                ReposUpdateRequestMergeCommitMessage.Blank => "BLANK",
                ReposUpdateRequestMergeCommitMessage.PrBody => "PR_BODY",
                ReposUpdateRequestMergeCommitMessage.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRequestMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => ReposUpdateRequestMergeCommitMessage.Blank,
                "PR_BODY" => ReposUpdateRequestMergeCommitMessage.PrBody,
                "PR_TITLE" => ReposUpdateRequestMergeCommitMessage.PrTitle,
                _ => null,
            };
        }
    }
}