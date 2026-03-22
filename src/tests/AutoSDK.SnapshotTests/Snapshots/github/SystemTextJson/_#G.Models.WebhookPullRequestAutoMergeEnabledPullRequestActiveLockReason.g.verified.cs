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
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        Spam,
        /// <summary>
        /// 
        /// </summary>
        TooHeated,
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
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.TooHeated => "too heated",
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
                "off-topic" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.Resolved,
                "spam" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.Spam,
                "too heated" => WebhookPullRequestAutoMergeEnabledPullRequestActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}