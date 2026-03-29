//HintName: G.Models.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType
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
    public static class ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio => "audio",
                ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code => "code",
                ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image => "image",
                ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown => "markdown",
                ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf => "pdf",
                ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text => "text",
                ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio,
                "code" => ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code,
                "image" => ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image,
                "markdown" => ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown,
                "pdf" => ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf,
                "text" => ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text,
                "video" => ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}