//HintName: G.Models.ScoredStoreFileChunksVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoredStoreFileChunksVariant1ItemDiscriminatorType
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
    public static class ScoredStoreFileChunksVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoredStoreFileChunksVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                ScoredStoreFileChunksVariant1ItemDiscriminatorType.AudioUrl => "audio_url",
                ScoredStoreFileChunksVariant1ItemDiscriminatorType.ImageUrl => "image_url",
                ScoredStoreFileChunksVariant1ItemDiscriminatorType.Text => "text",
                ScoredStoreFileChunksVariant1ItemDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoredStoreFileChunksVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => ScoredStoreFileChunksVariant1ItemDiscriminatorType.AudioUrl,
                "image_url" => ScoredStoreFileChunksVariant1ItemDiscriminatorType.ImageUrl,
                "text" => ScoredStoreFileChunksVariant1ItemDiscriminatorType.Text,
                "video_url" => ScoredStoreFileChunksVariant1ItemDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}