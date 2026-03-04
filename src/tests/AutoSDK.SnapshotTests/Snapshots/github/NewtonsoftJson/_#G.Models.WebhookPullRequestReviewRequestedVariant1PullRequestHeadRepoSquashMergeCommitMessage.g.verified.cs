//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage.g.cs

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
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage.CommitMessages,
                "BLANK" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoSquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}