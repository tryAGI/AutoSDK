//HintName: G.Models.ProjectResponseModelSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source type of the project.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelSourceType
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
    public static class ProjectResponseModelSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelSourceType value)
        {
            return value switch
            {
                ProjectResponseModelSourceType.Blank => "blank",
                ProjectResponseModelSourceType.Book => "book",
                ProjectResponseModelSourceType.Article => "article",
                ProjectResponseModelSourceType.Genfm => "genfm",
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
                "blank" => ProjectResponseModelSourceType.Blank,
                "book" => ProjectResponseModelSourceType.Book,
                "article" => ProjectResponseModelSourceType.Article,
                "genfm" => ProjectResponseModelSourceType.Genfm,
                _ => null,
            };
        }
    }
}