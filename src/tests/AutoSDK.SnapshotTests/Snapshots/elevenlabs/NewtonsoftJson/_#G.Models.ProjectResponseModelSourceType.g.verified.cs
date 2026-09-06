//HintName: G.Models.ProjectResponseModelSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="article")]
        Article,
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
        [global::System.Runtime.Serialization.EnumMember(Value="genfm")]
        Genfm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenplay")]
        Screenplay,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectResponseModelSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelSourceType value)
        {
            return value switch
            {
                ProjectResponseModelSourceType.Article => "article",
                ProjectResponseModelSourceType.Blank => "blank",
                ProjectResponseModelSourceType.Book => "book",
                ProjectResponseModelSourceType.Genfm => "genfm",
                ProjectResponseModelSourceType.Screenplay => "screenplay",
                ProjectResponseModelSourceType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelSourceType? ToEnum(string value)
        {
            return value switch
            {
                "article" => ProjectResponseModelSourceType.Article,
                "blank" => ProjectResponseModelSourceType.Blank,
                "book" => ProjectResponseModelSourceType.Book,
                "genfm" => ProjectResponseModelSourceType.Genfm,
                "screenplay" => ProjectResponseModelSourceType.Screenplay,
                "video" => ProjectResponseModelSourceType.Video,
                _ => null,
            };
        }
    }
}