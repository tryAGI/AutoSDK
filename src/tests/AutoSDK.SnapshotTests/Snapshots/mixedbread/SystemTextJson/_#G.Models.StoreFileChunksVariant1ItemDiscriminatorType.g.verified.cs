//HintName: G.Models.StoreFileChunksVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreFileChunksVariant1ItemDiscriminatorType
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
    public static class StoreFileChunksVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreFileChunksVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                StoreFileChunksVariant1ItemDiscriminatorType.AudioUrl => "audio_url",
                StoreFileChunksVariant1ItemDiscriminatorType.ImageUrl => "image_url",
                StoreFileChunksVariant1ItemDiscriminatorType.Text => "text",
                StoreFileChunksVariant1ItemDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreFileChunksVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => StoreFileChunksVariant1ItemDiscriminatorType.AudioUrl,
                "image_url" => StoreFileChunksVariant1ItemDiscriminatorType.ImageUrl,
                "text" => StoreFileChunksVariant1ItemDiscriminatorType.Text,
                "video_url" => StoreFileChunksVariant1ItemDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}