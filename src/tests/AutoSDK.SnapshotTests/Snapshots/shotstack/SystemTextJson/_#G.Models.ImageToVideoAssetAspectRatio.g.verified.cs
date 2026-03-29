//HintName: G.Models.ImageToVideoAssetAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aspect ratio (shape) of the video output.<br/>
    /// Example: 16:9
    /// </summary>
    public enum ImageToVideoAssetAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        x9_21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageToVideoAssetAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageToVideoAssetAspectRatio value)
        {
            return value switch
            {
                ImageToVideoAssetAspectRatio.x16_9 => "16:9",
                ImageToVideoAssetAspectRatio.x1_1 => "1:1",
                ImageToVideoAssetAspectRatio.x21_9 => "21:9",
                ImageToVideoAssetAspectRatio.x3_4 => "3:4",
                ImageToVideoAssetAspectRatio.x4_3 => "4:3",
                ImageToVideoAssetAspectRatio.x9_16 => "9:16",
                ImageToVideoAssetAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageToVideoAssetAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ImageToVideoAssetAspectRatio.x16_9,
                "1:1" => ImageToVideoAssetAspectRatio.x1_1,
                "21:9" => ImageToVideoAssetAspectRatio.x21_9,
                "3:4" => ImageToVideoAssetAspectRatio.x3_4,
                "4:3" => ImageToVideoAssetAspectRatio.x4_3,
                "9:16" => ImageToVideoAssetAspectRatio.x9_16,
                "9:21" => ImageToVideoAssetAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}