//HintName: G.Models.StoreQAResultsSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StoreQAResultsSourceDiscriminatorType
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
    public static class StoreQAResultsSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreQAResultsSourceDiscriminatorType value)
        {
            return value switch
            {
                StoreQAResultsSourceDiscriminatorType.AudioUrl => "audio_url",
                StoreQAResultsSourceDiscriminatorType.ImageUrl => "image_url",
                StoreQAResultsSourceDiscriminatorType.Text => "text",
                StoreQAResultsSourceDiscriminatorType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreQAResultsSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => StoreQAResultsSourceDiscriminatorType.AudioUrl,
                "image_url" => StoreQAResultsSourceDiscriminatorType.ImageUrl,
                "text" => StoreQAResultsSourceDiscriminatorType.Text,
                "video_url" => StoreQAResultsSourceDiscriminatorType.VideoUrl,
                _ => null,
            };
        }
    }
}