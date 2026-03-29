//HintName: G.Models.StoreSearchResponseDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StoreSearchResponseDataItemDiscriminatorType
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
    public static class StoreSearchResponseDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreSearchResponseDataItemDiscriminatorType value)
        {
            return value switch
            {
                StoreSearchResponseDataItemDiscriminatorType.AudioUrl => "audio_url",
                StoreSearchResponseDataItemDiscriminatorType.ImageUrl => "image_url",
                StoreSearchResponseDataItemDiscriminatorType.Text => "text",
                StoreSearchResponseDataItemDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreSearchResponseDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => StoreSearchResponseDataItemDiscriminatorType.AudioUrl,
                "image_url" => StoreSearchResponseDataItemDiscriminatorType.ImageUrl,
                "text" => StoreSearchResponseDataItemDiscriminatorType.Text,
                "video_url" => StoreSearchResponseDataItemDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}