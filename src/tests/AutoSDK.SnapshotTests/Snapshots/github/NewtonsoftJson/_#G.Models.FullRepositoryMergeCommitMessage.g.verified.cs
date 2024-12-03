//HintName: G.Models.FullRepositoryMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.<br/>
    /// Example: PR_BODY
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FullRepositoryMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_BODY")]
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_TITLE")]
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLANK")]
        BLANK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FullRepositoryMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FullRepositoryMergeCommitMessage value)
        {
            return value switch
            {
                FullRepositoryMergeCommitMessage.PRBODY => "PR_BODY",
                FullRepositoryMergeCommitMessage.PRTITLE => "PR_TITLE",
                FullRepositoryMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FullRepositoryMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => FullRepositoryMergeCommitMessage.PRBODY,
                "PR_TITLE" => FullRepositoryMergeCommitMessage.PRTITLE,
                "BLANK" => FullRepositoryMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}