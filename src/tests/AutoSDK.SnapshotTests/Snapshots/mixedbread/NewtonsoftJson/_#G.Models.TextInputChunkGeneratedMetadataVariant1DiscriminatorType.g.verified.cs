//HintName: G.Models.TextInputChunkGeneratedMetadataVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextInputChunkGeneratedMetadataVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pdf")]
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
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