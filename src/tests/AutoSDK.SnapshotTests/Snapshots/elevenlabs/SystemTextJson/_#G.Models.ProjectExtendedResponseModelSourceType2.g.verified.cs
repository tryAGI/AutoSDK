//HintName: G.Models.ProjectExtendedResponseModelSourceType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectExtendedResponseModelSourceType2
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
    public static class ProjectExtendedResponseModelSourceType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelSourceType2 value)
        {
            return value switch
            {
                ProjectExtendedResponseModelSourceType2.Article => "article",
                ProjectExtendedResponseModelSourceType2.Blank => "blank",
                ProjectExtendedResponseModelSourceType2.Book => "book",
                ProjectExtendedResponseModelSourceType2.Genfm => "genfm",
                ProjectExtendedResponseModelSourceType2.Screenplay => "screenplay",
                ProjectExtendedResponseModelSourceType2.Video => "video",
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
                "article" => ProjectExtendedResponseModelSourceType2.Article,
                "blank" => ProjectExtendedResponseModelSourceType2.Blank,
                "book" => ProjectExtendedResponseModelSourceType2.Book,
                "genfm" => ProjectExtendedResponseModelSourceType2.Genfm,
                "screenplay" => ProjectExtendedResponseModelSourceType2.Screenplay,
                "video" => ProjectExtendedResponseModelSourceType2.Video,
                _ => null,
            };
        }
    }
}