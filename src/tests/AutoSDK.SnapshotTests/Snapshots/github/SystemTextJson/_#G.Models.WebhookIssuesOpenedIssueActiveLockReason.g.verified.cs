//HintName: G.Models.WebhookIssuesOpenedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssueActiveLockReason
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
    public static class WebhookIssuesOpenedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesOpenedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesOpenedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesOpenedIssueActiveLockReason.Spam => "spam",
                WebhookIssuesOpenedIssueActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesOpenedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesOpenedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesOpenedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesOpenedIssueActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesOpenedIssueActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}