//HintName: G.Models.ReposCreateForAuthenticatedUserRequestMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposCreateForAuthenticatedUserRequestMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLANK")]
        Blank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_BODY")]
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PrTitle,
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
                ReposCreateForAuthenticatedUserRequestMergeCommitMessage.Blank => "BLANK",
                ReposCreateForAuthenticatedUserRequestMergeCommitMessage.PrBody => "PR_BODY",
                ReposCreateForAuthenticatedUserRequestMergeCommitMessage.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateForAuthenticatedUserRequestMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => ReposCreateForAuthenticatedUserRequestMergeCommitMessage.Blank,
                "PR_BODY" => ReposCreateForAuthenticatedUserRequestMergeCommitMessage.PrBody,
                "PR_TITLE" => ReposCreateForAuthenticatedUserRequestMergeCommitMessage.PrTitle,
                _ => null,
            };
        }
    }
}