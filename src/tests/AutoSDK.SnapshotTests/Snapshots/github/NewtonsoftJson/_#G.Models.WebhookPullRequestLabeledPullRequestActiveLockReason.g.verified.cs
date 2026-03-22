//HintName: G.Models.WebhookPullRequestLabeledPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLabeledPullRequestActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off-topic")]
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too heated")]
        TooHeated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLabeledPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestLabeledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookPullRequestLabeledPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestLabeledPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestLabeledPullRequestActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookPullRequestLabeledPullRequestActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestLabeledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookPullRequestLabeledPullRequestActiveLockReason.Resolved,
                "spam" => WebhookPullRequestLabeledPullRequestActiveLockReason.Spam,
                "too heated" => WebhookPullRequestLabeledPullRequestActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}