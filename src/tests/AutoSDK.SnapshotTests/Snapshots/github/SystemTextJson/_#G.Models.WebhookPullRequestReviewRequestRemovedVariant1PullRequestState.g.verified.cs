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
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
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
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.Open => "open",
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
                "closed" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.Closed,
                "open" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestState.Open,
                _ => null,
            };
        }
    }
}