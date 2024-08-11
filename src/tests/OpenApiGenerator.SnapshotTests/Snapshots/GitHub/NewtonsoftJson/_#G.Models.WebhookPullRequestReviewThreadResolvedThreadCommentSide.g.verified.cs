//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentSide
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentSide value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentSide.LEFT => "LEFT",
                WebhookPullRequestReviewThreadResolvedThreadCommentSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => WebhookPullRequestReviewThreadResolvedThreadCommentSide.LEFT,
                "RIGHT" => WebhookPullRequestReviewThreadResolvedThreadCommentSide.RIGHT,
                _ => null,
            };
        }
    }
}