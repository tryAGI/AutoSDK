//HintName: G.Models.RequestVeo31Ratio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum RequestVeo31Ratio
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
    public static class RequestVeo31RatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestVeo31Ratio value)
        {
            return value switch
            {
                RequestVeo31Ratio.x1280_720 => "1280:720",
                RequestVeo31Ratio.x720_1280 => "720:1280",
                RequestVeo31Ratio.x1080_1920 => "1080:1920",
                RequestVeo31Ratio.x1920_1080 => "1920:1080",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestVeo31Ratio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => RequestVeo31Ratio.x1280_720,
                "720:1280" => RequestVeo31Ratio.x720_1280,
                "1080:1920" => RequestVeo31Ratio.x1080_1920,
                "1920:1080" => RequestVeo31Ratio.x1920_1080,
                _ => null,
            };
        }
    }
}