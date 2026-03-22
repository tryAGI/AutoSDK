//HintName: G.Models.WebhookIssuesReopenedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssueActiveLockReason
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
    public static class WebhookIssuesReopenedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesReopenedIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookIssuesReopenedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesReopenedIssueActiveLockReason.Spam => "spam",
                WebhookIssuesReopenedIssueActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookIssuesReopenedIssueActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesReopenedIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookIssuesReopenedIssueActiveLockReason.Resolved,
                "spam" => WebhookIssuesReopenedIssueActiveLockReason.Spam,
                "too heated" => WebhookIssuesReopenedIssueActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}