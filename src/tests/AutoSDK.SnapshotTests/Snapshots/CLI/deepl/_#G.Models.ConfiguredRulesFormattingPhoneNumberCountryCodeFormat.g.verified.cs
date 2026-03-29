//HintName: G.Models.ConfiguredRulesFormattingPhoneNumberCountryCodeFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Phone Number Country Code Format
    /// </summary>
    public enum ConfiguredRulesFormattingPhoneNumberCountryCodeFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Use00BeforeCountryCode,
        /// <summary>
        /// 
        /// </summary>
        UsePlusSignBeforeCountryCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesFormattingPhoneNumberCountryCodeFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesFormattingPhoneNumberCountryCodeFormat value)
        {
            return value switch
            {
                ConfiguredRulesFormattingPhoneNumberCountryCodeFormat.Use00BeforeCountryCode => "use_00_before_country_code",
                ConfiguredRulesFormattingPhoneNumberCountryCodeFormat.UsePlusSignBeforeCountryCode => "use_plus_sign_before_country_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesFormattingPhoneNumberCountryCodeFormat? ToEnum(string value)
        {
            return value switch
            {
                "use_00_before_country_code" => ConfiguredRulesFormattingPhoneNumberCountryCodeFormat.Use00BeforeCountryCode,
                "use_plus_sign_before_country_code" => ConfiguredRulesFormattingPhoneNumberCountryCodeFormat.UsePlusSignBeforeCountryCode,
                _ => null,
            };
        }
    }
}