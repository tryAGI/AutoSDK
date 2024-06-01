//HintName: G.Models.PullsCreateReviewCommentRequestSubjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level at which the comment is targeted.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullsCreateReviewCommentRequestSubjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsCreateReviewCommentRequestSubjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsCreateReviewCommentRequestSubjectType value)
        {
            return value switch
            {
                PullsCreateReviewCommentRequestSubjectType.Line => "line",
                PullsCreateReviewCommentRequestSubjectType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsCreateReviewCommentRequestSubjectType ToEnum(string value)
        {
            return value switch
            {
                "line" => PullsCreateReviewCommentRequestSubjectType.Line,
                "file" => PullsCreateReviewCommentRequestSubjectType.File,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}