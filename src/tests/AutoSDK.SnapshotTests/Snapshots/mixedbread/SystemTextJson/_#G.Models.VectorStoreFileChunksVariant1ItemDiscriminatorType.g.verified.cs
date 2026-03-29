//HintName: G.Models.VectorStoreFileChunksVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VectorStoreFileChunksVariant1ItemDiscriminatorType
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
        Text,
        /// <summary>
        /// 
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileChunksVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileChunksVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                VectorStoreFileChunksVariant1ItemDiscriminatorType.AudioUrl => "audio_url",
                VectorStoreFileChunksVariant1ItemDiscriminatorType.ImageUrl => "image_url",
                VectorStoreFileChunksVariant1ItemDiscriminatorType.Text => "text",
                VectorStoreFileChunksVariant1ItemDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileChunksVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => VectorStoreFileChunksVariant1ItemDiscriminatorType.AudioUrl,
                "image_url" => VectorStoreFileChunksVariant1ItemDiscriminatorType.ImageUrl,
                "text" => VectorStoreFileChunksVariant1ItemDiscriminatorType.Text,
                "video_url" => VectorStoreFileChunksVariant1ItemDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}