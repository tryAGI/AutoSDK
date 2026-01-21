//HintName: G.Models.WebhookPullRequestUnassignedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestActiveLockReason
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
    public static class WebhookPullRequestUnassignedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestUnassignedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestUnassignedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestUnassignedPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestUnassignedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestUnassignedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestUnassignedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestUnassignedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestUnassignedPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestUnassignedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}