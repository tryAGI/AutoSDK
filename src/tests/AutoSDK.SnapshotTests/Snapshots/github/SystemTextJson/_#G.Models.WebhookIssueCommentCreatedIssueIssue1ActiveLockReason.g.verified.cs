//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1ActiveLockReason
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
    public static class WebhookIssueCommentCreatedIssueIssue1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.Spam => "spam",
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.Resolved,
                "spam" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.Spam,
                "too heated" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}