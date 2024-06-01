//HintName: G.Models.NullableRepositoryWebhooksMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NullableRepositoryWebhooksMergeCommitMessage
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
    public static class NullableRepositoryWebhooksMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableRepositoryWebhooksMergeCommitMessage value)
        {
            return value switch
            {
                NullableRepositoryWebhooksMergeCommitMessage.PRBODY => "PR_BODY",
                NullableRepositoryWebhooksMergeCommitMessage.PRTITLE => "PR_TITLE",
                NullableRepositoryWebhooksMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositoryWebhooksMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => NullableRepositoryWebhooksMergeCommitMessage.PRBODY,
                "PR_TITLE" => NullableRepositoryWebhooksMergeCommitMessage.PRTITLE,
                "BLANK" => NullableRepositoryWebhooksMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}