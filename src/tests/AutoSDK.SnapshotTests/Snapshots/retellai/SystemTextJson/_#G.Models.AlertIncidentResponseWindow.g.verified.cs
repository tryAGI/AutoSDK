//HintName: G.Models.AlertIncidentResponseWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Time window for metric evaluation.
    /// </summary>
    public enum AlertIncidentResponseWindow
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
        x3d,
        /// <summary>
        /// 
        /// </summary>
        x5m,
        /// <summary>
        /// 
        /// </summary>
        x7d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertIncidentResponseWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertIncidentResponseWindow value)
        {
            return value switch
            {
                AlertIncidentResponseWindow.x12h => "12h",
                AlertIncidentResponseWindow.x1h => "1h",
                AlertIncidentResponseWindow.x1m => "1m",
                AlertIncidentResponseWindow.x24h => "24h",
                AlertIncidentResponseWindow.x30m => "30m",
                AlertIncidentResponseWindow.x3d => "3d",
                AlertIncidentResponseWindow.x5m => "5m",
                AlertIncidentResponseWindow.x7d => "7d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertIncidentResponseWindow? ToEnum(string value)
        {
            return value switch
            {
                "12h" => AlertIncidentResponseWindow.x12h,
                "1h" => AlertIncidentResponseWindow.x1h,
                "1m" => AlertIncidentResponseWindow.x1m,
                "24h" => AlertIncidentResponseWindow.x24h,
                "30m" => AlertIncidentResponseWindow.x30m,
                "3d" => AlertIncidentResponseWindow.x3d,
                "5m" => AlertIncidentResponseWindow.x5m,
                "7d" => AlertIncidentResponseWindow.x7d,
                _ => null,
            };
        }
    }
}