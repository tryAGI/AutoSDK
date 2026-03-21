//HintName: G.Models.CreateImageToVideoRequestVeo31FastRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum CreateImageToVideoRequestVeo31FastRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1280_720,
        /// <summary>
        /// 
        /// </summary>
        x720_1280,
        /// <summary>
        /// 
        /// </summary>
        x1080_1920,
        /// <summary>
        /// 
        /// </summary>
        x1920_1080,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestVeo31FastRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestVeo31FastRatio value)
        {
            return value switch
            {
                CreateImageToVideoRequestVeo31FastRatio.x1280_720 => "1280:720",
                CreateImageToVideoRequestVeo31FastRatio.x720_1280 => "720:1280",
                CreateImageToVideoRequestVeo31FastRatio.x1080_1920 => "1080:1920",
                CreateImageToVideoRequestVeo31FastRatio.x1920_1080 => "1920:1080",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestVeo31FastRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => CreateImageToVideoRequestVeo31FastRatio.x1280_720,
                "720:1280" => CreateImageToVideoRequestVeo31FastRatio.x720_1280,
                "1080:1920" => CreateImageToVideoRequestVeo31FastRatio.x1080_1920,
                "1920:1080" => CreateImageToVideoRequestVeo31FastRatio.x1920_1080,
                _ => null,
            };
        }
    }
}