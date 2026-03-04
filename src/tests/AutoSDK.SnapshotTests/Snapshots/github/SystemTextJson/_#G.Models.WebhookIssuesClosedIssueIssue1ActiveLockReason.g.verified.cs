//HintName: G.Models.WebhookIssuesClosedIssueIssue1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1ActiveLockReason
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
    public static class WebhookIssuesClosedIssueIssue1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1ActiveLockReason.Resolved => "resolved",
                WebhookIssuesClosedIssueIssue1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesClosedIssueIssue1ActiveLockReason.TooHeated => "too heated",
                WebhookIssuesClosedIssueIssue1ActiveLockReason.Spam => "spam",
                WebhookIssuesClosedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesClosedIssueIssue1ActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesClosedIssueIssue1ActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesClosedIssueIssue1ActiveLockReason.TooHeated,
                "spam" => WebhookIssuesClosedIssueIssue1ActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesClosedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}