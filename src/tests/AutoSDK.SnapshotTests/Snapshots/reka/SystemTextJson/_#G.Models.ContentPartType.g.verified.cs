//HintName: G.Models.ContentPartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content part.
    /// </summary>
    public enum ContentPartType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioUrl,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        PdfUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
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