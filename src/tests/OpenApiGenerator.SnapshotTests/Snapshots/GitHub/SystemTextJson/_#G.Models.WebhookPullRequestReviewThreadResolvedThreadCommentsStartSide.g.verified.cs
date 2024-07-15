//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentsStartSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.<br/>
    /// Default Value: RIGHT
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentsStartSide
    {
        /// <summary>
        /// 
        /// </summary>
        LEFT,
        /// <summary>
        /// 
        /// </summary>
        RIGHT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentsStartSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentsStartSide value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentsStartSide.LEFT => "LEFT",
                WebhookPullRequestReviewThreadResolvedThreadCommentsStartSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentsStartSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => WebhookPullRequestReviewThreadResolvedThreadCommentsStartSide.LEFT,
                "RIGHT" => WebhookPullRequestReviewThreadResolvedThreadCommentsStartSide.RIGHT,
                _ => null,
            };
        }
    }
}