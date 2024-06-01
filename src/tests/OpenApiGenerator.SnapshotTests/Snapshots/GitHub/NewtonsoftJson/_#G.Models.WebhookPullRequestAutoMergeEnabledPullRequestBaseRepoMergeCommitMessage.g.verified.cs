//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default value for a merge commit message.
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.PRBODY => "PR_BODY",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.PRTITLE => "PR_TITLE",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.BLANK => "BLANK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage ToEnum(string value)
        {
            return value switch
            {
                "PR_BODY" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.PRBODY,
                "PR_TITLE" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.PRTITLE,
                "BLANK" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoMergeCommitMessage.BLANK,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}