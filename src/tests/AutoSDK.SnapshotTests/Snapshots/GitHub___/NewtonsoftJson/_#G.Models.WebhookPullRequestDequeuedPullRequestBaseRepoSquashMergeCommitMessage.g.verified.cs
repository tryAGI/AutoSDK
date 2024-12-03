//HintName: G.Models.WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage.g.cs

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
    public enum WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage
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
    public static class WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage.COMMITMESSAGES => "COMMIT_MESSAGES",
                WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage.PRBODY,
                "COMMIT_MESSAGES" => WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage.COMMITMESSAGES,
                "BLANK" => WebhookPullRequestDequeuedPullRequestBaseRepoSquashMergeCommitMessage.BLANK,
                _ => null,
            };
        }
    }
}