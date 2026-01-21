//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestAutoMergeDisabledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}