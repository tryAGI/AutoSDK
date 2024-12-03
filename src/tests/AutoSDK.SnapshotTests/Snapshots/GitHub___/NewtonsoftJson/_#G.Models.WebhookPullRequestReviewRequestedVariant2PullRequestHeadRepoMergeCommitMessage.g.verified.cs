//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage.g.cs

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
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestReviewRequestedVariant2PullRequestHeadRepoMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}