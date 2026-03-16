//HintName: G.Models.RequestGen4AlephRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.
    /// </summary>
    public enum RequestGen4AlephRatio
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
        x960_960,
        /// <summary>
        /// 
        /// </summary>
        x832_1104,
        /// <summary>
        /// 
        /// </summary>
        x1584_672,
        /// <summary>
        /// 
        /// </summary>
        x848_480,
        /// <summary>
        /// 
        /// </summary>
        x640_480,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestGen4AlephRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestGen4AlephRatio value)
        {
            return value switch
            {
                RequestGen4AlephRatio.x1280_720 => "1280:720",
                RequestGen4AlephRatio.x720_1280 => "720:1280",
                RequestGen4AlephRatio.x1104_832 => "1104:832",
                RequestGen4AlephRatio.x960_960 => "960:960",
                RequestGen4AlephRatio.x832_1104 => "832:1104",
                RequestGen4AlephRatio.x1584_672 => "1584:672",
                RequestGen4AlephRatio.x848_480 => "848:480",
                RequestGen4AlephRatio.x640_480 => "640:480",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestGen4AlephRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => RequestGen4AlephRatio.x1280_720,
                "720:1280" => RequestGen4AlephRatio.x720_1280,
                "1104:832" => RequestGen4AlephRatio.x1104_832,
                "960:960" => RequestGen4AlephRatio.x960_960,
                "832:1104" => RequestGen4AlephRatio.x832_1104,
                "1584:672" => RequestGen4AlephRatio.x1584_672,
                "848:480" => RequestGen4AlephRatio.x848_480,
                "640:480" => RequestGen4AlephRatio.x640_480,
                _ => null,
            };
        }
    }
}