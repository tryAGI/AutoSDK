//HintName: G.Models.CreateAssetRequestContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content type of the asset to upload. Must be one of: video/mp4, video/webm, or video/quicktime.<br/>
    /// Example: video/mp4
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssetRequestContentType
    {
        /// <summary>
        /// video/mp4, video/webm, or video/quicktime.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video/mp4")]
        VideoMp4,
        /// <summary>
        /// video/mp4, video/webm, or video/quicktime.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video/quicktime")]
        VideoQuicktime,
        /// <summary>
        /// video/mp4, video/webm, or video/quicktime.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video/webm")]
        VideoWebm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssetRequestContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetRequestContentType value)
        {
            return value switch
            {
                CreateAssetRequestContentType.VideoMp4 => "video/mp4",
                CreateAssetRequestContentType.VideoQuicktime => "video/quicktime",
                CreateAssetRequestContentType.VideoWebm => "video/webm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetRequestContentType? ToEnum(string value)
        {
            return value switch
            {
                "video/mp4" => CreateAssetRequestContentType.VideoMp4,
                "video/quicktime" => CreateAssetRequestContentType.VideoQuicktime,
                "video/webm" => CreateAssetRequestContentType.VideoWebm,
                _ => null,
            };
        }
    }
}