//HintName: G.Models.RepositoryWebhooksSquashMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a squash merge commit message:<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryWebhooksSquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLANK")]
        Blank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMMIT_MESSAGES")]
        CommitMessages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_BODY")]
        PrBody,
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
                RepositoryWebhooksSquashMergeCommitMessage.Blank => "BLANK",
                RepositoryWebhooksSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                RepositoryWebhooksSquashMergeCommitMessage.PrBody => "PR_BODY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryWebhooksSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => RepositoryWebhooksSquashMergeCommitMessage.Blank,
                "COMMIT_MESSAGES" => RepositoryWebhooksSquashMergeCommitMessage.CommitMessages,
                "PR_BODY" => RepositoryWebhooksSquashMergeCommitMessage.PrBody,
                _ => null,
            };
        }
    }
}