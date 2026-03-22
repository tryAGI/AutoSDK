//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewSubmittedPullRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewSubmittedPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestState.Closed => "closed",
                WebhookPullRequestReviewSubmittedPullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewSubmittedPullRequestState.Closed,
                "open" => WebhookPullRequestReviewSubmittedPullRequestState.Open,
                _ => null,
            };
        }
    }
}