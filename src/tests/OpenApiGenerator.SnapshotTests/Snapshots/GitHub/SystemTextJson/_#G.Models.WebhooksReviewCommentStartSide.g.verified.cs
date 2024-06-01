//HintName: G.Models.WebhooksReviewCommentStartSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.
    /// <br/>Default Value: RIGHT
    /// </summary>
    public enum WebhooksReviewCommentStartSide
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
    public static class WebhooksReviewCommentStartSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewCommentStartSide value)
        {
            return value switch
            {
                WebhooksReviewCommentStartSide.LEFT => "LEFT",
                WebhooksReviewCommentStartSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewCommentStartSide ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => WebhooksReviewCommentStartSide.LEFT,
                "RIGHT" => WebhooksReviewCommentStartSide.RIGHT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}