//HintName: G.Models.AlertRuleResponseThresholdType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether threshold is absolute or relative to previous period.
    /// </summary>
    public enum AlertRuleResponseThresholdType
    {
        /// <summary>
        /// 
        /// </summary>
        Absolute,
        /// <summary>
        /// 
        /// </summary>
        Relative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertRuleResponseThresholdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleResponseThresholdType value)
        {
            return value switch
            {
                AlertRuleResponseThresholdType.Absolute => "absolute",
                AlertRuleResponseThresholdType.Relative => "relative",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleResponseThresholdType? ToEnum(string value)
        {
            return value switch
            {
                "absolute" => AlertRuleResponseThresholdType.Absolute,
                "relative" => AlertRuleResponseThresholdType.Relative,
                _ => null,
            };
        }
    }
}