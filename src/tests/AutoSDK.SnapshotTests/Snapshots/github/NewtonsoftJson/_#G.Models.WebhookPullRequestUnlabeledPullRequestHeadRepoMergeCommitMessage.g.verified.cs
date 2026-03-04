//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLANK")]
        Blank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage.PrTitle,
                "BLANK" => WebhookPullRequestUnlabeledPullRequestHeadRepoMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}