//HintName: G.Models.AlertRuleResponseComparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator for the threshold.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertRuleResponseComparator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ge")]
        Ge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="le")]
        Le,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
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