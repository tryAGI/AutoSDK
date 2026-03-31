//HintName: G.Models.VectorStoreQAResultsSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VectorStoreQAResultsSourceDiscriminatorType
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
    public static class VectorStoreQAResultsSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreQAResultsSourceDiscriminatorType value)
        {
            return value switch
            {
                VectorStoreQAResultsSourceDiscriminatorType.AudioUrl => "audio_url",
                VectorStoreQAResultsSourceDiscriminatorType.ImageUrl => "image_url",
                VectorStoreQAResultsSourceDiscriminatorType.Text => "text",
                VectorStoreQAResultsSourceDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreQAResultsSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => VectorStoreQAResultsSourceDiscriminatorType.AudioUrl,
                "image_url" => VectorStoreQAResultsSourceDiscriminatorType.ImageUrl,
                "text" => VectorStoreQAResultsSourceDiscriminatorType.Text,
                "video_url" => VectorStoreQAResultsSourceDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}