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
    public static class WebhookIssuesOpenedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesOpenedIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookIssuesOpenedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesOpenedIssueActiveLockReason.Spam => "spam",
                WebhookIssuesOpenedIssueActiveLockReason.TooHeated => "too heated",
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
                "off-topic" => WebhookIssuesOpenedIssueActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesOpenedIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookIssuesOpenedIssueActiveLockReason.Resolved,
                "spam" => WebhookIssuesOpenedIssueActiveLockReason.Spam,
                "too heated" => WebhookIssuesOpenedIssueActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}