//HintName: G.Models.PullRequestReviewCommentSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted, can be a diff line or a file.
    /// </summary>
    public enum PullRequestReviewCommentSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullRequestReviewCommentSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestReviewCommentSubjectType value)
        {
            return value switch
            {
                PullRequestReviewCommentSubjectType.Line => "line",
                PullRequestReviewCommentSubjectType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestReviewCommentSubjectType? ToEnum(string value)
        {
            return value switch
            {
                "line" => PullRequestReviewCommentSubjectType.Line,
                "file" => PullRequestReviewCommentSubjectType.File,
                _ => null,
            };
        }
    }
}