//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}