//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueIssue1ActiveLockReason
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
    public static class WebhookIssueCommentCreatedIssueIssue1ActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1ActiveLockReason value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.Resolved => "resolved",
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.OffTopic => "off-topic",
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.TooHeated => "too heated",
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.Spam => "spam",
                WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
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
                "resolved" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.Resolved,
                "off-topic" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.OffTopic,
                "too heated" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.TooHeated,
                "spam" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookIssueCommentCreatedIssueIssue1ActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                _ => null,
            };
        }
    }
}