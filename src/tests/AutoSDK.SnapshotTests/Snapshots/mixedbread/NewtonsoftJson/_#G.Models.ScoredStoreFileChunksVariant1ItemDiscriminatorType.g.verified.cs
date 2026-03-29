//HintName: G.Models.ScoredStoreFileChunksVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScoredStoreFileChunksVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_url")]
        AudioUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video_url")]
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