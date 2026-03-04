//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1ActiveLockReason
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
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentDeletedIssueIssue1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.Spam => "spam",
                WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssueCommentDeletedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}