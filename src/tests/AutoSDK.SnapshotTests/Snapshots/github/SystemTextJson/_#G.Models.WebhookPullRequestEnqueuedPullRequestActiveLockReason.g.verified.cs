//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestActiveLockReason
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
    public static class WebhookPullRequestEnqueuedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestEnqueuedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestEnqueuedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}