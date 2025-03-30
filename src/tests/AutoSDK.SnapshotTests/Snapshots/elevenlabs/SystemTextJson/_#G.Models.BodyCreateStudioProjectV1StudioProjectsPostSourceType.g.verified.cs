//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of Studio project to create.<br/>
    /// Example: book
    /// </summary>
    public enum BodyCreateStudioProjectV1StudioProjectsPostSourceType
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
    public static class BodyCreateStudioProjectV1StudioProjectsPostSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostSourceType value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Blank => "blank",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Book => "book",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Article => "article",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Genfm => "genfm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostSourceType? ToEnum(string value)
        {
            return value switch
            {
                "blank" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Blank,
                "book" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Book,
                "article" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Article,
                "genfm" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Genfm,
                _ => null,
            };
        }
    }
}