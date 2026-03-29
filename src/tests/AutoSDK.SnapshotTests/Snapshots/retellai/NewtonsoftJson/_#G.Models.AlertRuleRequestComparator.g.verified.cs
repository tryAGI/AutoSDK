//HintName: G.Models.AlertRuleRequestComparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator for the threshold.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertRuleRequestComparator
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
    public static class AlertRuleRequestComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleRequestComparator value)
        {
            return value switch
            {
                AlertRuleRequestComparator.Ge => "ge",
                AlertRuleRequestComparator.Gt => "gt",
                AlertRuleRequestComparator.Le => "le",
                AlertRuleRequestComparator.Lt => "lt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleRequestComparator? ToEnum(string value)
        {
            return value switch
            {
                "ge" => AlertRuleRequestComparator.Ge,
                "gt" => AlertRuleRequestComparator.Gt,
                "le" => AlertRuleRequestComparator.Le,
                "lt" => AlertRuleRequestComparator.Lt,
                _ => null,
            };
        }
    }
}