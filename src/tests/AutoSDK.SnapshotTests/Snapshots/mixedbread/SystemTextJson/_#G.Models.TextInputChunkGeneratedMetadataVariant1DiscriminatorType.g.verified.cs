//HintName: G.Models.TextInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextInputChunkGeneratedMetadataVariant1DiscriminatorType
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
    public static class TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextInputChunkGeneratedMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio => "audio",
                TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Code => "code",
                TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Image => "image",
                TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown => "markdown",
                TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf => "pdf",
                TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Text => "text",
                TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextInputChunkGeneratedMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Audio,
                "code" => TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Code,
                "image" => TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Image,
                "markdown" => TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Markdown,
                "pdf" => TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Pdf,
                "text" => TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Text,
                "video" => TextInputChunkGeneratedMetadataVariant1DiscriminatorType.Video,
                _ => null,
            };
        }
    }
}