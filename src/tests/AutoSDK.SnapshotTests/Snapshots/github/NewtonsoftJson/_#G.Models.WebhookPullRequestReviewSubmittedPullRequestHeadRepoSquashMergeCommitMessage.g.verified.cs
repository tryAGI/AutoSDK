//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage.g.cs

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
    public enum WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage
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
    public static class WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage.CommitMessages => "COMMIT_MESSAGES",
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage.Blank => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage.PrBody,
                "COMMIT_MESSAGES" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage.CommitMessages,
                "BLANK" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoSquashMergeCommitMessage.Blank,
                _ => null,
            };
        }
    }
}