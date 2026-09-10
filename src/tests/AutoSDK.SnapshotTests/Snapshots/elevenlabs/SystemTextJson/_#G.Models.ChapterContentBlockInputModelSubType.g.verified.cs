//HintName: G.Models.ChapterContentBlockInputModelSubType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChapterContentBlockInputModelSubType
    {
        /// <summary>
        /// 
        /// </summary>
        H1,
        /// <summary>
        /// 
        /// </summary>
        H2,
        /// <summary>
        /// 
        /// </summary>
        H3,
        /// <summary>
        /// 
        /// </summary>
        P,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChapterContentBlockInputModelSubTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterContentBlockInputModelSubType value)
        {
            return value switch
            {
                ChapterContentBlockInputModelSubType.H1 => "h1",
                ChapterContentBlockInputModelSubType.H2 => "h2",
                ChapterContentBlockInputModelSubType.H3 => "h3",
                ChapterContentBlockInputModelSubType.P => "p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterContentBlockInputModelSubType? ToEnum(string value)
        {
            return value switch
            {
                "h1" => ChapterContentBlockInputModelSubType.H1,
                "h2" => ChapterContentBlockInputModelSubType.H2,
                "h3" => ChapterContentBlockInputModelSubType.H3,
                "p" => ChapterContentBlockInputModelSubType.P,
                _ => null,
            };
        }
    }
}