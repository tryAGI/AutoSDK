//HintName: G.Models.WebhookIssuesUnlockedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssueActiveLockReason
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
    public static class WebhookIssuesUnlockedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesUnlockedIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookIssuesUnlockedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesUnlockedIssueActiveLockReason.Spam => "spam",
                WebhookIssuesUnlockedIssueActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookIssuesUnlockedIssueActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssuesUnlockedIssueActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookIssuesUnlockedIssueActiveLockReason.Resolved,
                "spam" => WebhookIssuesUnlockedIssueActiveLockReason.Spam,
                "too heated" => WebhookIssuesUnlockedIssueActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}