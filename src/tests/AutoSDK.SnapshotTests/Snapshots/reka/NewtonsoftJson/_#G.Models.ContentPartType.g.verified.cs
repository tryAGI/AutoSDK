//HintName: G.Models.ContentPartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content part.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentPartType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_url")]
        AudioUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pdf_url")]
        PdfUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video_url")]
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentPartType value)
        {
            return value switch
            {
                ContentPartType.AudioUrl => "audio_url",
                ContentPartType.ImageUrl => "image_url",
                ContentPartType.PdfUrl => "pdf_url",
                ContentPartType.Text => "text",
                ContentPartType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentPartType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => ContentPartType.AudioUrl,
                "image_url" => ContentPartType.ImageUrl,
                "pdf_url" => ContentPartType.PdfUrl,
                "text" => ContentPartType.Text,
                "video_url" => ContentPartType.VideoUrl,
                _ => null,
            };
        }
    }
}