//HintName: G.Models.PullsCreateReviewCommentRequestStartSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when using multi-line comments unless using `in_reply_to`**. The `start_side` is the starting side of the diff that the comment applies to. Can be `LEFT` or `RIGHT`. To learn more about multi-line comments, see "[Commenting on a pull request](https://docs.github.com/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)" in the GitHub Help documentation. See `side` in this table for additional context.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullsCreateReviewCommentRequestStartSide
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LEFT")]
        LEFT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RIGHT")]
        RIGHT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="side")]
        Side,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsCreateReviewCommentRequestStartSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsCreateReviewCommentRequestStartSide value)
        {
            return value switch
            {
                PullsCreateReviewCommentRequestStartSide.LEFT => "LEFT",
                PullsCreateReviewCommentRequestStartSide.RIGHT => "RIGHT",
                PullsCreateReviewCommentRequestStartSide.Side => "side",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsCreateReviewCommentRequestStartSide ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => PullsCreateReviewCommentRequestStartSide.LEFT,
                "RIGHT" => PullsCreateReviewCommentRequestStartSide.RIGHT,
                "side" => PullsCreateReviewCommentRequestStartSide.Side,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}