//HintName: G.Models.WebhookPullRequestReviewCommentCreatedCommentStartSide.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.
    /// <br/>Default Value: RIGHT
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedCommentStartSide
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
    public static class WebhookPullRequestReviewCommentCreatedCommentStartSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedCommentStartSide value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedCommentStartSide.LEFT => "LEFT",
                WebhookPullRequestReviewCommentCreatedCommentStartSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedCommentStartSide ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => WebhookPullRequestReviewCommentCreatedCommentStartSide.LEFT,
                "RIGHT" => WebhookPullRequestReviewCommentCreatedCommentStartSide.RIGHT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}