//HintName: G.Models.StoreSearchResponseDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreSearchResponseDataItemDiscriminatorType
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