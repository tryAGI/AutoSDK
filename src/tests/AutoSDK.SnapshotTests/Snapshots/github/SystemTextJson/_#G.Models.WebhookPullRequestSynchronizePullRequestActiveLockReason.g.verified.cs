//HintName: G.Models.WebhookPullRequestSynchronizePullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestActiveLockReason
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
    public static class WebhookPullRequestSynchronizePullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestSynchronizePullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestSynchronizePullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestSynchronizePullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestSynchronizePullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestSynchronizePullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestSynchronizePullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestSynchronizePullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestSynchronizePullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestSynchronizePullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}