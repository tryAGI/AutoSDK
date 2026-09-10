//HintName: G.Models.ProjectExtendedResponseModelSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectExtendedResponseModelSourceType
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
    public static class ProjectExtendedResponseModelSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelSourceType value)
        {
            return value switch
            {
                ProjectExtendedResponseModelSourceType.Article => "article",
                ProjectExtendedResponseModelSourceType.Blank => "blank",
                ProjectExtendedResponseModelSourceType.Book => "book",
                ProjectExtendedResponseModelSourceType.Genfm => "genfm",
                ProjectExtendedResponseModelSourceType.Screenplay => "screenplay",
                ProjectExtendedResponseModelSourceType.Video => "video",
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
                "article" => ProjectExtendedResponseModelSourceType.Article,
                "blank" => ProjectExtendedResponseModelSourceType.Blank,
                "book" => ProjectExtendedResponseModelSourceType.Book,
                "genfm" => ProjectExtendedResponseModelSourceType.Genfm,
                "screenplay" => ProjectExtendedResponseModelSourceType.Screenplay,
                "video" => ProjectExtendedResponseModelSourceType.Video,
                _ => null,
            };
        }
    }
}