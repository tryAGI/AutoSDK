//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}