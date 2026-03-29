//HintName: G.Models.VectorStoreFileChunksVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreFileChunksVariant1ItemDiscriminatorType
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