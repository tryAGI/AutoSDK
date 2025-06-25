//HintName: G.Models.PullRequestReviewCommentSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment<br/>
    /// Default Value: RIGHT
    /// </summary>
    public enum PullRequestReviewCommentSide
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
    public static class PullRequestReviewCommentSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestReviewCommentSide value)
        {
            return value switch
            {
                PullRequestReviewCommentSide.LEFT => "LEFT",
                PullRequestReviewCommentSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestReviewCommentSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => PullRequestReviewCommentSide.LEFT,
                "RIGHT" => PullRequestReviewCommentSide.RIGHT,
                _ => null,
            };
        }
    }
}