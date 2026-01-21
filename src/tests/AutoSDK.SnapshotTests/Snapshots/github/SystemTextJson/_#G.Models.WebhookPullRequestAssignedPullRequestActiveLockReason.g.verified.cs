//HintName: G.Models.WebhookPullRequestAssignedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestActiveLockReason
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
    public static class WebhookPullRequestAssignedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestAssignedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestAssignedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestAssignedPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestAssignedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestAssignedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestAssignedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestAssignedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestAssignedPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestAssignedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}