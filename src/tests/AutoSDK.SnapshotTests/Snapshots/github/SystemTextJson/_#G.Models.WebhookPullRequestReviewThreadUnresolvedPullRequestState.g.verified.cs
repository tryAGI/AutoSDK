//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestState
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestState.Closed => "closed",
                WebhookPullRequestReviewThreadUnresolvedPullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewThreadUnresolvedPullRequestState.Closed,
                "open" => WebhookPullRequestReviewThreadUnresolvedPullRequestState.Open,
                _ => null,
            };
        }
    }
}