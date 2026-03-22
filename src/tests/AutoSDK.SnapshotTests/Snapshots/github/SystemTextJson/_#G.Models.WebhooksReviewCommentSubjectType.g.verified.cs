//HintName: G.Models.WebhooksReviewCommentSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    public enum WebhooksReviewCommentSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Line,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksReviewCommentSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewCommentSubjectType value)
        {
            return value switch
            {
                WebhooksReviewCommentSubjectType.File => "file",
                WebhooksReviewCommentSubjectType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewCommentSubjectType? ToEnum(string value)
        {
            return value switch
            {
                "file" => WebhooksReviewCommentSubjectType.File,
                "line" => WebhooksReviewCommentSubjectType.Line,
                _ => null,
            };
        }
    }
}