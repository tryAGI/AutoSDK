//HintName: G.Models.ProjectExtendedResponseModelSourceType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectExtendedResponseModelSourceType2
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
    public static class ProjectExtendedResponseModelSourceType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelSourceType2 value)
        {
            return value switch
            {
                ProjectExtendedResponseModelSourceType2.Blank => "blank",
                ProjectExtendedResponseModelSourceType2.Book => "book",
                ProjectExtendedResponseModelSourceType2.Article => "article",
                ProjectExtendedResponseModelSourceType2.Genfm => "genfm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelSourceType2? ToEnum(string value)
        {
            return value switch
            {
                "blank" => ProjectExtendedResponseModelSourceType2.Blank,
                "book" => ProjectExtendedResponseModelSourceType2.Book,
                "article" => ProjectExtendedResponseModelSourceType2.Article,
                "genfm" => ProjectExtendedResponseModelSourceType2.Genfm,
                _ => null,
            };
        }
    }
}