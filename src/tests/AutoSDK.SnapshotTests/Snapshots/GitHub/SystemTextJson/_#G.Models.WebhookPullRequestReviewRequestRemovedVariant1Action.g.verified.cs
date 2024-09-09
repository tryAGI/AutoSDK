//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1Action.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1Action
    {
        /// <summary>
        /// 
        /// </summary>
        ReviewRequestRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1Action value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1Action.ReviewRequestRemoved => "review_request_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1Action? ToEnum(string value)
        {
            return value switch
            {
                "review_request_removed" => WebhookPullRequestReviewRequestRemovedVariant1Action.ReviewRequestRemoved,
                _ => null,
            };
        }
    }
}