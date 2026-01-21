//HintName: G.Models.ProjectResponseModelSourceType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelSourceType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blank")]
        Blank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="book")]
        Book,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="article")]
        Article,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="genfm")]
        Genfm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectResponseModelSourceType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelSourceType2 value)
        {
            return value switch
            {
                ProjectResponseModelSourceType2.Blank => "blank",
                ProjectResponseModelSourceType2.Book => "book",
                ProjectResponseModelSourceType2.Article => "article",
                ProjectResponseModelSourceType2.Genfm => "genfm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelSourceType2? ToEnum(string value)
        {
            return value switch
            {
                "blank" => ProjectResponseModelSourceType2.Blank,
                "book" => ProjectResponseModelSourceType2.Book,
                "article" => ProjectResponseModelSourceType2.Article,
                "genfm" => ProjectResponseModelSourceType2.Genfm,
                _ => null,
            };
        }
    }
}