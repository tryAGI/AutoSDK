//HintName: G.Models.WebhookIssuesLabeledIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssueActiveLockReason
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
    public static class WebhookIssuesLabeledIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesLabeledIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesLabeledIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesLabeledIssueActiveLockReason.Spam => "spam",
                WebhookIssuesLabeledIssueActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesLabeledIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesLabeledIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesLabeledIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesLabeledIssueActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesLabeledIssueActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}