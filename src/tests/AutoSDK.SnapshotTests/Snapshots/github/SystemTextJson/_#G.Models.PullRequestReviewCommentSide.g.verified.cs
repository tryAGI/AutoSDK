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
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
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
                PullRequestReviewCommentSide.Left => "LEFT",
                PullRequestReviewCommentSide.Right => "RIGHT",
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
                "LEFT" => PullRequestReviewCommentSide.Left,
                "RIGHT" => PullRequestReviewCommentSide.Right,
                _ => null,
            };
        }
    }
}