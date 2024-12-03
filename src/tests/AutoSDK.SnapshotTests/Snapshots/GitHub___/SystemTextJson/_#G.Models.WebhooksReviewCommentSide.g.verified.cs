//HintName: G.Models.WebhooksReviewCommentSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.
    /// </summary>
    public enum WebhooksReviewCommentSide
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
    public static class WebhooksReviewCommentSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewCommentSide value)
        {
            return value switch
            {
                WebhooksReviewCommentSide.LEFT => "LEFT",
                WebhooksReviewCommentSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewCommentSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => WebhooksReviewCommentSide.LEFT,
                "RIGHT" => WebhooksReviewCommentSide.RIGHT,
                _ => null,
            };
        }
    }
}