//HintName: G.Models.ChapterContentBlockInputModelSubType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChapterContentBlockInputModelSubType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="p")]
        P,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="h1")]
        H1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="h2")]
        H2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="h3")]
        H3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChapterContentBlockInputModelSubType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterContentBlockInputModelSubType2 value)
        {
            return value switch
            {
                ChapterContentBlockInputModelSubType2.P => "p",
                ChapterContentBlockInputModelSubType2.H1 => "h1",
                ChapterContentBlockInputModelSubType2.H2 => "h2",
                ChapterContentBlockInputModelSubType2.H3 => "h3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterContentBlockInputModelSubType2? ToEnum(string value)
        {
            return value switch
            {
                "p" => ChapterContentBlockInputModelSubType2.P,
                "h1" => ChapterContentBlockInputModelSubType2.H1,
                "h2" => ChapterContentBlockInputModelSubType2.H2,
                "h3" => ChapterContentBlockInputModelSubType2.H3,
                _ => null,
            };
        }
    }
}