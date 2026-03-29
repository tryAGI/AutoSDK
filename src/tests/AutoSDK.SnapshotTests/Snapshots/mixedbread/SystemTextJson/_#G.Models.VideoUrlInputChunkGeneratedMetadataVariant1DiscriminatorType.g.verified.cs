//HintName: G.Models.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio => "audio",
                VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code => "code",
                VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image => "image",
                VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown => "markdown",
                VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf => "pdf",
                VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text => "text",
                VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio,
                "code" => VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code,
                "image" => VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image,
                "markdown" => VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown,
                "pdf" => VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf,
                "text" => VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text,
                "video" => VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}