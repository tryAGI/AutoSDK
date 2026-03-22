//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostSourceType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostSourceType2
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
    public static class BodyCreateStudioProjectV1StudioProjectsPostSourceType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostSourceType2 value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Article => "article",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Blank => "blank",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Book => "book",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Genfm => "genfm",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Screenplay => "screenplay",
                BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostSourceType2? ToEnum(string value)
        {
            return value switch
            {
                "article" => BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Article,
                "blank" => BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Blank,
                "book" => BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Book,
                "genfm" => BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Genfm,
                "screenplay" => BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Screenplay,
                "video" => BodyCreateStudioProjectV1StudioProjectsPostSourceType2.Video,
                _ => null,
            };
        }
    }
}