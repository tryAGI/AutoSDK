//HintName: G.Models.AlertIncidentResponseFrequency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Evaluation frequency.
    /// </summary>
    public enum AlertIncidentResponseFrequency
    {
        /// <summary>
        /// 
        /// </summary>
        x12h,
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x1m,
        /// <summary>
        /// 
        /// </summary>
        x24h,
        /// <summary>
        /// 
        /// </summary>
        x30m,
        /// <summary>
        /// 
        /// </summary>
        x5m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertIncidentResponseFrequencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertIncidentResponseFrequency value)
        {
            return value switch
            {
                AlertIncidentResponseFrequency.x12h => "12h",
                AlertIncidentResponseFrequency.x1h => "1h",
                AlertIncidentResponseFrequency.x1m => "1m",
                AlertIncidentResponseFrequency.x24h => "24h",
                AlertIncidentResponseFrequency.x30m => "30m",
                AlertIncidentResponseFrequency.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertIncidentResponseFrequency? ToEnum(string value)
        {
            return value switch
            {
                "12h" => AlertIncidentResponseFrequency.x12h,
                "1h" => AlertIncidentResponseFrequency.x1h,
                "1m" => AlertIncidentResponseFrequency.x1m,
                "24h" => AlertIncidentResponseFrequency.x24h,
                "30m" => AlertIncidentResponseFrequency.x30m,
                "5m" => AlertIncidentResponseFrequency.x5m,
                _ => null,
            };
        }
    }
}