//HintName: G.Models.WebhookPullRequestReviewSubmittedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Submitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewSubmittedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedAction value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedAction.Submitted => "submitted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedAction? ToEnum(string value)
        {
            return value switch
            {
                "submitted" => WebhookPullRequestReviewSubmittedAction.Submitted,
                _ => null,
            };
        }
    }
}