//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestReviewCommentDeletedPullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}