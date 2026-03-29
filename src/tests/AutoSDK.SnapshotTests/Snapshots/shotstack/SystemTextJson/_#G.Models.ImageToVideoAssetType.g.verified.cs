//HintName: G.Models.ImageToVideoAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `image-to-video` for image-to-video.<br/>
    /// Default Value: image-to-video
    /// </summary>
    public enum ImageToVideoAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageToVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoAssetType value)
        {
            return value switch
            {
                ImageToVideoAssetType.ImageToVideo => "image-to-video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoAssetType? ToEnum(string value)
        {
            return value switch
            {
                "image-to-video" => ImageToVideoAssetType.ImageToVideo,
                _ => null,
            };
        }
    }
}