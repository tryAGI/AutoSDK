//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.Spam => "spam",
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.Spam,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.OpenapiJsonNullSentinelValue2BF936000FE44250987AE5DDB203E464,
                _ => null,
            };
        }
    }
}