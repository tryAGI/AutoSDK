//HintName: G.Models.ChapterContentParagraphTtsNodeInputModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChapterContentParagraphTtsNodeInputModelType
    {
        /// <summary>
        /// 
        /// </summary>
        TtsNode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChapterContentParagraphTtsNodeInputModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterContentParagraphTtsNodeInputModelType value)
        {
            return value switch
            {
                ChapterContentParagraphTtsNodeInputModelType.TtsNode => "tts_node",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterContentParagraphTtsNodeInputModelType? ToEnum(string value)
        {
            return value switch
            {
                "tts_node" => ChapterContentParagraphTtsNodeInputModelType.TtsNode,
                _ => null,
            };
        }
    }
}