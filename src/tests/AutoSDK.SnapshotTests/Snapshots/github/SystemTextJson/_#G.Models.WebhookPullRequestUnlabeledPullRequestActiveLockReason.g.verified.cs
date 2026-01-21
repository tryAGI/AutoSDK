//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestActiveLockReason
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
    public static class WebhookPullRequestUnlabeledPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestUnlabeledPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestUnlabeledPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestUnlabeledPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestUnlabeledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestUnlabeledPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestUnlabeledPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestUnlabeledPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestUnlabeledPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestUnlabeledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}