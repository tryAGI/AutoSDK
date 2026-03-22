//HintName: G.Models.CreateImageToVideoRequestVeo31Ratio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateImageToVideoRequestVeo31Ratio
    {
        /// <summary>
        /// 
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x1920_1080,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestVeo31RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestVeo31Ratio value)
        {
            return value switch
            {
                CreateImageToVideoRequestVeo31Ratio.x1080_1920 => "1080:1920",
                CreateImageToVideoRequestVeo31Ratio.x1280_720 => "1280:720",
                CreateImageToVideoRequestVeo31Ratio.x1920_1080 => "1920:1080",
                CreateImageToVideoRequestVeo31Ratio.x720_1280 => "720:1280",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestVeo31Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1080:1920" => CreateImageToVideoRequestVeo31Ratio.x1080_1920,
                "1280:720" => CreateImageToVideoRequestVeo31Ratio.x1280_720,
                "1920:1080" => CreateImageToVideoRequestVeo31Ratio.x1920_1080,
                "720:1280" => CreateImageToVideoRequestVeo31Ratio.x720_1280,
                _ => null,
            };
        }
    }
}