﻿//HintName: G.Models.ReviewCommentSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.<br/>
    /// Default Value: RIGHT
    /// </summary>
    public enum ReviewCommentSide
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
    public static class ReviewCommentSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewCommentSide value)
        {
            return value switch
            {
                ReviewCommentSide.LEFT => "LEFT",
                ReviewCommentSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewCommentSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => ReviewCommentSide.LEFT,
                "RIGHT" => ReviewCommentSide.RIGHT,
                _ => null,
            };
        }
    }
}