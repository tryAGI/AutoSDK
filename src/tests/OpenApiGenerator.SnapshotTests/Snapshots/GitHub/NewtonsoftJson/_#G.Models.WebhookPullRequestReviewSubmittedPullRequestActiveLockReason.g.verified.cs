//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewSubmittedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewSubmittedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewSubmittedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}