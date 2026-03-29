//HintName: G.Models.AlertRuleResponseComparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator for the threshold.
    /// </summary>
    public enum AlertRuleResponseComparator
    {
        /// <summary>
        /// 
        /// </summary>
        Ge,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Le,
        /// <summary>
        /// 
        /// </summary>
        Lt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertRuleResponseComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleResponseComparator value)
        {
            return value switch
            {
                AlertRuleResponseComparator.Ge => "ge",
                AlertRuleResponseComparator.Gt => "gt",
                AlertRuleResponseComparator.Le => "le",
                AlertRuleResponseComparator.Lt => "lt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleResponseComparator? ToEnum(string value)
        {
            return value switch
            {
                "ge" => AlertRuleResponseComparator.Ge,
                "gt" => AlertRuleResponseComparator.Gt,
                "le" => AlertRuleResponseComparator.Le,
                "lt" => AlertRuleResponseComparator.Lt,
                _ => null,
            };
        }
    }
}