//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostSourceType
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
    public static class BodyCreateStudioProjectV1StudioProjectsPostSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostSourceType value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Article => "article",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Blank => "blank",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Book => "book",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Genfm => "genfm",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Screenplay => "screenplay",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType.Video => "video",
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
                "article" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Article,
                "blank" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Blank,
                "book" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Book,
                "genfm" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Genfm,
                "screenplay" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Screenplay,
                "video" => BodyCreateStudioProjectV1StudioProjectsPostSourceType.Video,
                _ => null,
            };
        }
    }
}