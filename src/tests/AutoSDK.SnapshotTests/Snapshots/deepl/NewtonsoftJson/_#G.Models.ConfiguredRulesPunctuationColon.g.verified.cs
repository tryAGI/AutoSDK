//HintName: G.Models.ConfiguredRulesPunctuationColon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Colon
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationColon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_colon")]
        UseFullWidthColon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_half_width_colon")]
        UseHalfWidthColon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationColonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationColon value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationColon.UseFullWidthColon => "use_full_width_colon",
                ConfiguredRulesPunctuationColon.UseHalfWidthColon => "use_half_width_colon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationColon? ToEnum(string value)
        {
            return value switch
            {
                "use_full_width_colon" => ConfiguredRulesPunctuationColon.UseFullWidthColon,
                "use_half_width_colon" => ConfiguredRulesPunctuationColon.UseHalfWidthColon,
                _ => null,
            };
        }
    }
}