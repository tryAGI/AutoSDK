//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssueActiveLockReason
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
    public static class WebhookIssuesOpenedChangesOldIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.Spam => "spam",
                WebhookIssuesOpenedChangesOldIssueActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.Resolved,
                "spam" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.Spam,
                "too heated" => WebhookIssuesOpenedChangesOldIssueActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}