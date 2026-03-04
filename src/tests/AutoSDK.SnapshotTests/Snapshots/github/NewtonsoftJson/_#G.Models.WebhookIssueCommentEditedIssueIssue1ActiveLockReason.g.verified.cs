//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueIssue1ActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off-topic")]
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too heated")]
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssueIssue1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentEditedIssueIssue1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentEditedIssueIssue1ActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentEditedIssueIssue1ActiveLockReason.Spam => "spam",
                WebhookIssueCommentEditedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1ActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssueCommentEditedIssueIssue1ActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentEditedIssueIssue1ActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentEditedIssueIssue1ActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentEditedIssueIssue1ActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssueCommentEditedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}