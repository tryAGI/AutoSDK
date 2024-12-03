//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2Action.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant2Action
    {
        /// <summary>
        /// 
        /// </summary>
        ReviewRequested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2Action value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2Action.ReviewRequested => "review_requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "review_requested" => WebhookPullRequestReviewRequestedVariant2Action.ReviewRequested,
                _ => null,
            };
        }
    }
}