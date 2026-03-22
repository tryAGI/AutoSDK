//HintName: G.Models.WebhooksPullRequest5ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5ActiveLockReason
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
    public static class WebhooksPullRequest5ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5ActiveLockReason value)
        {
            return value switch
            {
                WebhooksPullRequest5ActiveLockReason.OffTopic => "off-topic",
                WebhooksPullRequest5ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhooksPullRequest5ActiveLockReason.Resolved => "resolved",
                WebhooksPullRequest5ActiveLockReason.Spam => "spam",
                WebhooksPullRequest5ActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhooksPullRequest5ActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhooksPullRequest5ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhooksPullRequest5ActiveLockReason.Resolved,
                "spam" => WebhooksPullRequest5ActiveLockReason.Spam,
                "too heated" => WebhooksPullRequest5ActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}