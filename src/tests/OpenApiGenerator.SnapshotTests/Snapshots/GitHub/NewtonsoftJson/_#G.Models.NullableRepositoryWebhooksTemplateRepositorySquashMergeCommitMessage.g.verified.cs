//HintName: G.Models.NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_BODY")]
        PRBODY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMMIT_MESSAGES")]
        COMMITMESSAGES,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLANK")]
        BLANK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage value)
        {
            return value switch
            {
                NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.PRBODY => "PR_BODY",
                NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => NullableRepositoryWebhooksTemplateRepositorySquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}