//HintName: G.Models.AlertRuleRequestFrequency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How often to evaluate the metric.
    /// </summary>
    public enum AlertRuleRequestFrequency
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
    public static class AlertRuleRequestFrequencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleRequestFrequency value)
        {
            return value switch
            {
                AlertRuleRequestFrequency.x12h => "12h",
                AlertRuleRequestFrequency.x1h => "1h",
                AlertRuleRequestFrequency.x1m => "1m",
                AlertRuleRequestFrequency.x24h => "24h",
                AlertRuleRequestFrequency.x30m => "30m",
                AlertRuleRequestFrequency.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleRequestFrequency? ToEnum(string value)
        {
            return value switch
            {
                "12h" => AlertRuleRequestFrequency.x12h,
                "1h" => AlertRuleRequestFrequency.x1h,
                "1m" => AlertRuleRequestFrequency.x1m,
                "24h" => AlertRuleRequestFrequency.x24h,
                "30m" => AlertRuleRequestFrequency.x30m,
                "5m" => AlertRuleRequestFrequency.x5m,
                _ => null,
            };
        }
    }
}