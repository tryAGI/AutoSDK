//HintName: G.Models.ConfiguredRulesPunctuationSerialComma.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Serial Comma
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationSerialComma
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use")]
        DoNotUse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_serial_comma_when_using_chinese_comma")]
        DoNotUseSerialCommaWhenUsingChineseComma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use")]
        Use,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_serial_comma_when_using_comma")]
        UseSerialCommaWhenUsingComma,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationSerialCommaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationSerialComma value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationSerialComma.DoNotUse => "do_not_use",
                ConfiguredRulesPunctuationSerialComma.DoNotUseSerialCommaWhenUsingChineseComma => "do_not_use_serial_comma_when_using_chinese_comma",
                ConfiguredRulesPunctuationSerialComma.Use => "use",
                ConfiguredRulesPunctuationSerialComma.UseSerialCommaWhenUsingComma => "use_serial_comma_when_using_comma",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationSerialComma? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesPunctuationSerialComma.DoNotUse,
                "do_not_use_serial_comma_when_using_chinese_comma" => ConfiguredRulesPunctuationSerialComma.DoNotUseSerialCommaWhenUsingChineseComma,
                "use" => ConfiguredRulesPunctuationSerialComma.Use,
                "use_serial_comma_when_using_comma" => ConfiguredRulesPunctuationSerialComma.UseSerialCommaWhenUsingComma,
                _ => null,
            };
        }
    }
}