//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2Action.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        ReviewRequestRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2Action value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2Action.ReviewRequestRemoved => "review_request_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "review_request_removed" => WebhookPullRequestReviewRequestRemovedVariant2Action.ReviewRequestRemoved,
                _ => null,
            };
        }
    }
}