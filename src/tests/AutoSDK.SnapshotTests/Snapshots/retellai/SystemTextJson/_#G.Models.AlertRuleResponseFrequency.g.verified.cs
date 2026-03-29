//HintName: G.Models.AlertRuleResponseFrequency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How often the metric is evaluated.
    /// </summary>
    public enum AlertRuleResponseFrequency
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
    public static class AlertRuleResponseFrequencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleResponseFrequency value)
        {
            return value switch
            {
                AlertRuleResponseFrequency.x12h => "12h",
                AlertRuleResponseFrequency.x1h => "1h",
                AlertRuleResponseFrequency.x1m => "1m",
                AlertRuleResponseFrequency.x24h => "24h",
                AlertRuleResponseFrequency.x30m => "30m",
                AlertRuleResponseFrequency.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleResponseFrequency? ToEnum(string value)
        {
            return value switch
            {
                "12h" => AlertRuleResponseFrequency.x12h,
                "1h" => AlertRuleResponseFrequency.x1h,
                "1m" => AlertRuleResponseFrequency.x1m,
                "24h" => AlertRuleResponseFrequency.x24h,
                "30m" => AlertRuleResponseFrequency.x30m,
                "5m" => AlertRuleResponseFrequency.x5m,
                _ => null,
            };
        }
    }
}