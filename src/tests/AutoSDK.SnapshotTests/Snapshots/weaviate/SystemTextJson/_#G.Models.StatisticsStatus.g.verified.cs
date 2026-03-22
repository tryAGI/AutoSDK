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
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
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
                StatisticsStatus.Timeout => "TIMEOUT",
                StatisticsStatus.Unavailable => "UNAVAILABLE",
                StatisticsStatus.Unhealthy => "UNHEALTHY",
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
                "TIMEOUT" => StatisticsStatus.Timeout,
                "UNAVAILABLE" => StatisticsStatus.Unavailable,
                "UNHEALTHY" => StatisticsStatus.Unhealthy,
                _ => null,
            };
        }
    }
}