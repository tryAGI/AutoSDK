//HintName: G.Models.WebhookPullRequestLabeledPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
        Spam,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
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
                WebhookPullRequestLabeledPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestLabeledPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestLabeledPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestLabeledPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestLabeledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "resolved" => WebhookPullRequestLabeledPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestLabeledPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestLabeledPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestLabeledPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestLabeledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}