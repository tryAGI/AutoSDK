//HintName: G.Models.WebhookPullRequestReadyForReviewAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReadyForReviewAction
    {
        /// <summary>
        /// 
        /// </summary>
        ReadyForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReadyForReviewActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReadyForReviewAction value)
        {
            return value switch
            {
                WebhookPullRequestReadyForReviewAction.ReadyForReview => "ready_for_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReadyForReviewAction ToEnum(string value)
        {
            return value switch
            {
                "ready_for_review" => WebhookPullRequestReadyForReviewAction.ReadyForReview,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}