//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off-topic")]
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too heated")]
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewEditedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}