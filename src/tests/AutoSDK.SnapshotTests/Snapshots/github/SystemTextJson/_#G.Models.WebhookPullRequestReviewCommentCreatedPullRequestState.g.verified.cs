//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentCreatedPullRequestState
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestState.Closed => "closed",
                WebhookPullRequestReviewCommentCreatedPullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewCommentCreatedPullRequestState.Closed,
                "open" => WebhookPullRequestReviewCommentCreatedPullRequestState.Open,
                _ => null,
            };
        }
    }
}