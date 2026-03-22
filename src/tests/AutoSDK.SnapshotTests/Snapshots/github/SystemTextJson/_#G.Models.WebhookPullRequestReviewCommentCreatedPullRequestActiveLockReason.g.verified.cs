//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.TooHeated => "too heated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "off-topic" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.OffTopic,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "resolved" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.Resolved,
                "spam" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.Spam,
                "too heated" => WebhookPullRequestReviewCommentCreatedPullRequestActiveLockReason.TooHeated,
                _ => null,
            };
        }
    }
}