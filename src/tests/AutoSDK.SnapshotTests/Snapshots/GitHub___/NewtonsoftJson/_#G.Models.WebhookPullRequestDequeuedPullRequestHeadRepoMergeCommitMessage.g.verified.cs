//HintName: G.Models.WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage.g.cs

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
    public enum WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage
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
    public static class WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestDequeuedPullRequestHeadRepoMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}