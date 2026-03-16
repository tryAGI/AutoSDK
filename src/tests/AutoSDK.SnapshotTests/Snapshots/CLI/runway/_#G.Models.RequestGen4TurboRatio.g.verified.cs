//HintName: G.Models.RequestGen4TurboRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum RequestGen4TurboRatio
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
        x1104_832,
        /// <summary>
        /// 
        /// </summary>
        x832_1104,
        /// <summary>
        /// 
        /// </summary>
        x960_960,
        /// <summary>
        /// 
        /// </summary>
        x1584_672,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestGen4TurboRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGen4TurboRatio value)
        {
            return value switch
            {
                RequestGen4TurboRatio.x1280_720 => "1280:720",
                RequestGen4TurboRatio.x720_1280 => "720:1280",
                RequestGen4TurboRatio.x1104_832 => "1104:832",
                RequestGen4TurboRatio.x832_1104 => "832:1104",
                RequestGen4TurboRatio.x960_960 => "960:960",
                RequestGen4TurboRatio.x1584_672 => "1584:672",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGen4TurboRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => RequestGen4TurboRatio.x1280_720,
                "720:1280" => RequestGen4TurboRatio.x720_1280,
                "1104:832" => RequestGen4TurboRatio.x1104_832,
                "832:1104" => RequestGen4TurboRatio.x832_1104,
                "960:960" => RequestGen4TurboRatio.x960_960,
                "1584:672" => RequestGen4TurboRatio.x1584_672,
                _ => null,
            };
        }
    }
}