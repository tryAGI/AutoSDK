//HintName: G.Models.PullRequestWebhookVariant2SquashMergeCommitMessage.g.cs

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
    public enum PullRequestWebhookVariant2SquashMergeCommitMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PR_BODY")]
        PrBody,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMMIT_MESSAGES")]
        CommitMessages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLANK")]
        Blank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullRequestWebhookVariant2SquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestWebhookVariant2SquashMergeCommitMessage value)
        {
            return value switch
            {
                PullRequestWebhookVariant2SquashMergeCommitMessage.PrBody => "PR_BODY",
                PullRequestWebhookVariant2SquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                PullRequestWebhookVariant2SquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestWebhookVariant2SquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => PullRequestWebhookVariant2SquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => PullRequestWebhookVariant2SquashMergeCommitMessage.CommitMessages,
                "BLANK" => PullRequestWebhookVariant2SquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}