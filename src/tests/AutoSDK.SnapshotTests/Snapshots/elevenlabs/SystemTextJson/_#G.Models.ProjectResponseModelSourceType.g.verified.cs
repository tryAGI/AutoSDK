//HintName: G.Models.ProjectResponseModelSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectResponseModelSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Article,
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
        Genfm,
        /// <summary>
        /// 
        /// </summary>
        Screenplay,
        /// <summary>
        /// 
        /// </summary>
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