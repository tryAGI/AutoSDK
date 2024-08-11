//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}