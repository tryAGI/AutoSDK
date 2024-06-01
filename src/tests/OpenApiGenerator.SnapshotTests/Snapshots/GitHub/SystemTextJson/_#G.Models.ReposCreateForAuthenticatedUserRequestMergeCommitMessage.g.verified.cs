//HintName: G.Models.ReposCreateForAuthenticatedUserRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum ReposCreateForAuthenticatedUserRequestMergeCommitMessage
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
    public static class ReposCreateForAuthenticatedUserRequestMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateForAuthenticatedUserRequestMergeCommitMessage value)
        {
            return value switch
            {
                ReposCreateForAuthenticatedUserRequestMergeCommitMessage.PRBODY => "PR_BODY",
                ReposCreateForAuthenticatedUserRequestMergeCommitMessage.PRTITLE => "PR_TITLE",
                ReposCreateForAuthenticatedUserRequestMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateForAuthenticatedUserRequestMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => ReposCreateForAuthenticatedUserRequestMergeCommitMessage.PRBODY,
                "PR_TITLE" => ReposCreateForAuthenticatedUserRequestMergeCommitMessage.PRTITLE,
                "BLANK" => ReposCreateForAuthenticatedUserRequestMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}