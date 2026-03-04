//HintName: G.Models.ReviewCommentStartSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.<br/>
    /// Default Value: RIGHT
    /// </summary>
    public enum ReviewCommentStartSide
    {
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewCommentStartSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewCommentStartSide value)
        {
            return value switch
            {
                ReviewCommentStartSide.Left => "LEFT",
                ReviewCommentStartSide.Right => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewCommentStartSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => ReviewCommentStartSide.Left,
                "RIGHT" => ReviewCommentStartSide.Right,
                _ => null,
            };
        }
    }
}