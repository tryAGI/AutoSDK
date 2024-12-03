//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage.g.cs

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
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestHeadRepoMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}