//HintName: G.Models.VideoAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `video` for videos.<br/>
    /// Default Value: video
    /// </summary>
    public enum VideoAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAssetType value)
        {
            return value switch
            {
                VideoAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAssetType? ToEnum(string value)
        {
            return value switch
            {
                "video" => VideoAssetType.Video,
                _ => null,
            };
        }
    }
}