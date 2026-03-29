//HintName: G.Models.ConfiguredRulesPunctuationEmDash.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Em Dash
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationEmDash
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_em_dash")]
        UseDoubleEmDash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationEmDashExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationEmDash value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationEmDash.UseDoubleEmDash => "use_double_em_dash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationEmDash? ToEnum(string value)
        {
            return value switch
            {
                "use_double_em_dash" => ConfiguredRulesPunctuationEmDash.UseDoubleEmDash,
                _ => null,
            };
        }
    }
}