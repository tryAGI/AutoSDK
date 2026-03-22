//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssueActiveLockReason
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
    public static class WebhookIssuesTransferredChangesNewIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.Spam => "spam",
                WebhookIssuesTransferredChangesNewIssueActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.Resolved,
                "spam" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.Spam,
                "too heated" => WebhookIssuesTransferredChangesNewIssueActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}