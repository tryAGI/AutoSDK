//HintName: G.Models.PostChapterizationMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: post_chapterization<br/>
    /// Example: post_chapterization
    /// </summary>
    public enum PostChapterizationMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        PostChapterization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostChapterizationMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostChapterizationMessageType value)
        {
            return value switch
            {
                PostChapterizationMessageType.PostChapterization => "post_chapterization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostChapterizationMessageType? ToEnum(string value)
        {
            return value switch
            {
                "post_chapterization" => PostChapterizationMessageType.PostChapterization,
                _ => null,
            };
        }
    }
}