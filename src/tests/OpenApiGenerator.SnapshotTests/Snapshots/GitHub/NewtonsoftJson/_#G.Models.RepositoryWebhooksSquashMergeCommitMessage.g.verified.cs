//HintName: G.Models.RepositoryWebhooksSquashMergeCommitMessage.g.cs

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
    public enum RepositoryWebhooksSquashMergeCommitMessage
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
    public static class RepositoryWebhooksSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryWebhooksSquashMergeCommitMessage value)
        {
            return value switch
            {
                RepositoryWebhooksSquashMergeCommitMessage.PRBODY => "PR_BODY",
                RepositoryWebhooksSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                RepositoryWebhooksSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksSquashMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => RepositoryWebhooksSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => RepositoryWebhooksSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => RepositoryWebhooksSquashMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}