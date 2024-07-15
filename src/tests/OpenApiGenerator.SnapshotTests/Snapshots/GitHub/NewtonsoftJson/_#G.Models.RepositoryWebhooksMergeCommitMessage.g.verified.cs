//HintName: G.Models.RepositoryWebhooksMergeCommitMessage.g.cs

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
    public enum RepositoryWebhooksMergeCommitMessage
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
    public static class RepositoryWebhooksMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksMergeCommitMessage value)
        {
            return value switch
            {
                RepositoryWebhooksMergeCommitMessage.PRBODY => "PR_BODY",
                RepositoryWebhooksMergeCommitMessage.PRTITLE => "PR_TITLE",
                RepositoryWebhooksMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => RepositoryWebhooksMergeCommitMessage.PRBODY,
                "PR_TITLE" => RepositoryWebhooksMergeCommitMessage.PRTITLE,
                "BLANK" => RepositoryWebhooksMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}