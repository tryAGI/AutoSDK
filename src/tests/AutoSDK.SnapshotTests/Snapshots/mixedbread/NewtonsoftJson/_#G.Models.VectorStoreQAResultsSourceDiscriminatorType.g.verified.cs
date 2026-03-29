//HintName: G.Models.VectorStoreQAResultsSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreQAResultsSourceDiscriminatorType
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