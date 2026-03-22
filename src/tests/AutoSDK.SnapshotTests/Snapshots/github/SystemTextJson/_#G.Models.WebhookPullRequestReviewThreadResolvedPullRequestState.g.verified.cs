//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestState
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestState.Closed => "closed",
                WebhookPullRequestReviewThreadResolvedPullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewThreadResolvedPullRequestState.Closed,
                "open" => WebhookPullRequestReviewThreadResolvedPullRequestState.Open,
                _ => null,
            };
        }
    }
}