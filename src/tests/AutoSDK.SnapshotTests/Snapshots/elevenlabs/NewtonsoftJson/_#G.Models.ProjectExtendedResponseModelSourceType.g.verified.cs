//HintName: G.Models.ProjectExtendedResponseModelSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The source type of the project.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectExtendedResponseModelSourceType
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
    public static class ProjectExtendedResponseModelSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelSourceType value)
        {
            return value switch
            {
                ProjectExtendedResponseModelSourceType.Blank => "blank",
                ProjectExtendedResponseModelSourceType.Book => "book",
                ProjectExtendedResponseModelSourceType.Article => "article",
                ProjectExtendedResponseModelSourceType.Genfm => "genfm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelSourceType? ToEnum(string value)
        {
            return value switch
            {
                "blank" => ProjectExtendedResponseModelSourceType.Blank,
                "book" => ProjectExtendedResponseModelSourceType.Book,
                "article" => ProjectExtendedResponseModelSourceType.Article,
                "genfm" => ProjectExtendedResponseModelSourceType.Genfm,
                _ => null,
            };
        }
    }
}