//HintName: G.Models.VectorStoreSearchResponseDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreSearchResponseDataItemDiscriminatorType
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
    public static class VectorStoreSearchResponseDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreSearchResponseDataItemDiscriminatorType value)
        {
            return value switch
            {
                VectorStoreSearchResponseDataItemDiscriminatorType.AudioUrl => "audio_url",
                VectorStoreSearchResponseDataItemDiscriminatorType.ImageUrl => "image_url",
                VectorStoreSearchResponseDataItemDiscriminatorType.Text => "text",
                VectorStoreSearchResponseDataItemDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreSearchResponseDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => VectorStoreSearchResponseDataItemDiscriminatorType.AudioUrl,
                "image_url" => VectorStoreSearchResponseDataItemDiscriminatorType.ImageUrl,
                "text" => VectorStoreSearchResponseDataItemDiscriminatorType.Text,
                "video_url" => VectorStoreSearchResponseDataItemDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}