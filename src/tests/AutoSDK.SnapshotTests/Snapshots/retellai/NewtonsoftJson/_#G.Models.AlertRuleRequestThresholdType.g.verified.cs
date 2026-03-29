//HintName: G.Models.AlertRuleRequestThresholdType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether threshold is absolute or relative to previous period.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertRuleRequestThresholdType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="absolute")]
        Absolute,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="relative")]
        Relative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertRuleRequestThresholdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertRuleRequestThresholdType value)
        {
            return value switch
            {
                AlertRuleRequestThresholdType.Absolute => "absolute",
                AlertRuleRequestThresholdType.Relative => "relative",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertRuleRequestThresholdType? ToEnum(string value)
        {
            return value switch
            {
                "absolute" => AlertRuleRequestThresholdType.Absolute,
                "relative" => AlertRuleRequestThresholdType.Relative,
                _ => null,
            };
        }
    }
}