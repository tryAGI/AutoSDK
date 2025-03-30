//HintName: G.Models.BodyAddProjectV1ProjectsAddPostSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of Studio project to create.<br/>
    /// Example: book
    /// </summary>
    public enum BodyAddProjectV1ProjectsAddPostSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        Book,
        /// <summary>
        /// 
        /// </summary>
        Article,
        /// <summary>
        /// 
        /// </summary>
        Genfm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyAddProjectV1ProjectsAddPostSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAddProjectV1ProjectsAddPostSourceType value)
        {
            return value switch
            {
                BodyAddProjectV1ProjectsAddPostSourceType.Blank => "blank",
                BodyAddProjectV1ProjectsAddPostSourceType.Book => "book",
                BodyAddProjectV1ProjectsAddPostSourceType.Article => "article",
                BodyAddProjectV1ProjectsAddPostSourceType.Genfm => "genfm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAddProjectV1ProjectsAddPostSourceType? ToEnum(string value)
        {
            return value switch
            {
                "blank" => BodyAddProjectV1ProjectsAddPostSourceType.Blank,
                "book" => BodyAddProjectV1ProjectsAddPostSourceType.Book,
                "article" => BodyAddProjectV1ProjectsAddPostSourceType.Article,
                "genfm" => BodyAddProjectV1ProjectsAddPostSourceType.Genfm,
                _ => null,
            };
        }
    }
}