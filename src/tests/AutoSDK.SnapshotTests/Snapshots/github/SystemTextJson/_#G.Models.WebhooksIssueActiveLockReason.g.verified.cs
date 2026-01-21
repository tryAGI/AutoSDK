//HintName: G.Models.WebhooksIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssueActiveLockReason
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
    public static class WebhooksIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueActiveLockReason value)
        {
            return value switch
            {
                WebhooksIssueActiveLockReason.Resolved => "resolved",
                WebhooksIssueActiveLockReason.OffTopic => "off-topic",
                WebhooksIssueActiveLockReason.TooHeated => "too heated",
                WebhooksIssueActiveLockReason.Spam => "spam",
                WebhooksIssueActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhooksIssueActiveLockReason.Resolved,
                "off-topic" => WebhooksIssueActiveLockReason.OffTopic,
                "too heated" => WebhooksIssueActiveLockReason.TooHeated,
                "spam" => WebhooksIssueActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhooksIssueActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}