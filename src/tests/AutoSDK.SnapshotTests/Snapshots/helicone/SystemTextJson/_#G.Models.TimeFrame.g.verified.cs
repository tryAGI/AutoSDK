//HintName: G.Models.TimeFrame.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimeFrame
    {
        /// <summary>
        /// 
        /// </summary>
        x24h,
        /// <summary>
        /// 
        /// </summary>
        x30d,
        /// <summary>
        /// 
        /// </summary>
        x7d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimeFrameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimeFrame value)
        {
            return value switch
            {
                TimeFrame.x24h => "24h",
                TimeFrame.x30d => "30d",
                TimeFrame.x7d => "7d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimeFrame? ToEnum(string value)
        {
            return value switch
            {
                "24h" => TimeFrame.x24h,
                "30d" => TimeFrame.x30d,
                "7d" => TimeFrame.x7d,
                _ => null,
            };
        }
    }
}