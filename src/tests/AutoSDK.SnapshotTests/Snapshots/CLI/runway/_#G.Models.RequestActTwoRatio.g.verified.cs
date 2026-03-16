//HintName: G.Models.RequestActTwoRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The resolution of the output video.<br/>
    /// Example: 1280:720
    /// </summary>
    public enum RequestActTwoRatio
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
        x960_960,
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
        x1584_672,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestActTwoRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestActTwoRatio value)
        {
            return value switch
            {
                RequestActTwoRatio.x1280_720 => "1280:720",
                RequestActTwoRatio.x720_1280 => "720:1280",
                RequestActTwoRatio.x960_960 => "960:960",
                RequestActTwoRatio.x1104_832 => "1104:832",
                RequestActTwoRatio.x832_1104 => "832:1104",
                RequestActTwoRatio.x1584_672 => "1584:672",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestActTwoRatio? ToEnum(string value)
        {
            return value switch
            {
                "1280:720" => RequestActTwoRatio.x1280_720,
                "720:1280" => RequestActTwoRatio.x720_1280,
                "960:960" => RequestActTwoRatio.x960_960,
                "1104:832" => RequestActTwoRatio.x1104_832,
                "832:1104" => RequestActTwoRatio.x832_1104,
                "1584:672" => RequestActTwoRatio.x1584_672,
                _ => null,
            };
        }
    }
}