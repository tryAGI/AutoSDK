//HintName: G.Models.VectorStoreSearchResponseDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VectorStoreSearchResponseDataItemDiscriminatorType
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