//HintName: G.Models.BodyAddProjectV1ProjectsAddPostSourceType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyAddProjectV1ProjectsAddPostSourceType2
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
    public static class BodyAddProjectV1ProjectsAddPostSourceType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAddProjectV1ProjectsAddPostSourceType2 value)
        {
            return value switch
            {
                BodyAddProjectV1ProjectsAddPostSourceType2.Blank => "blank",
                BodyAddProjectV1ProjectsAddPostSourceType2.Book => "book",
                BodyAddProjectV1ProjectsAddPostSourceType2.Article => "article",
                BodyAddProjectV1ProjectsAddPostSourceType2.Genfm => "genfm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAddProjectV1ProjectsAddPostSourceType2? ToEnum(string value)
        {
            return value switch
            {
                "blank" => BodyAddProjectV1ProjectsAddPostSourceType2.Blank,
                "book" => BodyAddProjectV1ProjectsAddPostSourceType2.Book,
                "article" => BodyAddProjectV1ProjectsAddPostSourceType2.Article,
                "genfm" => BodyAddProjectV1ProjectsAddPostSourceType2.Genfm,
                _ => null,
            };
        }
    }
}