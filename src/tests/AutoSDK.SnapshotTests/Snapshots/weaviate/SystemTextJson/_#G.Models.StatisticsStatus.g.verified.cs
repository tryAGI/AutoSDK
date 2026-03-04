//HintName: G.Models.StatisticsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Node's status.<br/>
    /// Default Value: HEALTHY
    /// </summary>
    public enum StatisticsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Healthy,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatisticsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatisticsStatus value)
        {
            return value switch
            {
                StatisticsStatus.Healthy => "HEALTHY",
                StatisticsStatus.Unhealthy => "UNHEALTHY",
                StatisticsStatus.Unavailable => "UNAVAILABLE",
                StatisticsStatus.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatisticsStatus? ToEnum(string value)
        {
            return value switch
            {
                "HEALTHY" => StatisticsStatus.Healthy,
                "UNHEALTHY" => StatisticsStatus.Unhealthy,
                "UNAVAILABLE" => StatisticsStatus.Unavailable,
                "TIMEOUT" => StatisticsStatus.Timeout,
                _ => null,
            };
        }
    }
}