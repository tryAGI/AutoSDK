//HintName: G.Models.ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType
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
    public static class ScoredVectorStoreFileChunksVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.AudioUrl => "audio_url",
                ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.ImageUrl => "image_url",
                ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.Text => "text",
                ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.AudioUrl,
                "image_url" => ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.ImageUrl,
                "text" => ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.Text,
                "video_url" => ScoredVectorStoreFileChunksVariant1ItemDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}