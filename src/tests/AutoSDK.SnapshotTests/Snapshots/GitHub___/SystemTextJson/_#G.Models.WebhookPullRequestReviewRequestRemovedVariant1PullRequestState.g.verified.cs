//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.Closed,
                _ => null,
            };
        }
    }
}