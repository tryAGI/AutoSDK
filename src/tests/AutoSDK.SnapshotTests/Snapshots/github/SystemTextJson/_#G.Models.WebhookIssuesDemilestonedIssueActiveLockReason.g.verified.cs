//HintName: G.Models.WebhookIssuesDemilestonedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueActiveLockReason
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
    public static class WebhookIssuesDemilestonedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesDemilestonedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesDemilestonedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesDemilestonedIssueActiveLockReason.Spam => "spam",
                WebhookIssuesDemilestonedIssueActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesDemilestonedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesDemilestonedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesDemilestonedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesDemilestonedIssueActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesDemilestonedIssueActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}