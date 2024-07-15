//HintName: G.Models.PullsCreateReviewCommentRequestSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// In a split diff view, the side of the diff that the pull request's changes appear on. Can be `LEFT` or `RIGHT`. Use `LEFT` for deletions that appear in red. Use `RIGHT` for additions that appear in green or unchanged lines that appear in white and are shown for context. For a multi-line comment, side represents whether the last line of the comment range is a deletion or addition. For more information, see "[Diff view options](https://docs.github.com/articles/about-comparing-branches-in-pull-requests#diff-view-options)" in the GitHub Help documentation.
    /// </summary>
    public enum PullsCreateReviewCommentRequestSide
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
    public static class PullsCreateReviewCommentRequestSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsCreateReviewCommentRequestSide value)
        {
            return value switch
            {
                PullsCreateReviewCommentRequestSide.LEFT => "LEFT",
                PullsCreateReviewCommentRequestSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsCreateReviewCommentRequestSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => PullsCreateReviewCommentRequestSide.LEFT,
                "RIGHT" => PullsCreateReviewCommentRequestSide.RIGHT,
                _ => null,
            };
        }
    }
}