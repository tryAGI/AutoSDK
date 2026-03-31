//HintName: G.Models.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType
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
    public static class AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio => "audio",
                AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code => "code",
                AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image => "image",
                AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown => "markdown",
                AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf => "pdf",
                AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text => "text",
                AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio,
                "code" => AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Code,
                "image" => AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Image,
                "markdown" => AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown,
                "pdf" => AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf,
                "text" => AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Text,
                "video" => AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}