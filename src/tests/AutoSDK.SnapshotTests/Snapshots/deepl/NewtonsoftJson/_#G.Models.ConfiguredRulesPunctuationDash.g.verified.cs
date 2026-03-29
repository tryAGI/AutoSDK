//HintName: G.Models.ConfiguredRulesPunctuationDash.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Dash
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationDash
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_em_dash")]
        UseEmDash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_hyphen")]
        UseHyphen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_tilde")]
        UseTilde,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationDashExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationDash value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationDash.UseEmDash => "use_em_dash",
                ConfiguredRulesPunctuationDash.UseHyphen => "use_hyphen",
                ConfiguredRulesPunctuationDash.UseTilde => "use_tilde",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationDash? ToEnum(string value)
        {
            return value switch
            {
                "use_em_dash" => ConfiguredRulesPunctuationDash.UseEmDash,
                "use_hyphen" => ConfiguredRulesPunctuationDash.UseHyphen,
                "use_tilde" => ConfiguredRulesPunctuationDash.UseTilde,
                _ => null,
            };
        }
    }
}