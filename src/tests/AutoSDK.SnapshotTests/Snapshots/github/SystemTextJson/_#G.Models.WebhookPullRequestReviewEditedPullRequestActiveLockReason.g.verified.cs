//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewEditedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewEditedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestReviewEditedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestReviewEditedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}