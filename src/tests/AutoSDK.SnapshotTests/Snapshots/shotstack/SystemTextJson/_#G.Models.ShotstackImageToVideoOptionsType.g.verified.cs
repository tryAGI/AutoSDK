//HintName: G.Models.ShotstackImageToVideoOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `image-to-video` for image-to-video.<br/>
    /// Default Value: image-to-video
    /// </summary>
    public enum ShotstackImageToVideoOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageToVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShotstackImageToVideoOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShotstackImageToVideoOptionsType value)
        {
            return value switch
            {
                ShotstackImageToVideoOptionsType.ImageToVideo => "image-to-video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShotstackImageToVideoOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "image-to-video" => ShotstackImageToVideoOptionsType.ImageToVideo,
                _ => null,
            };
        }
    }
}