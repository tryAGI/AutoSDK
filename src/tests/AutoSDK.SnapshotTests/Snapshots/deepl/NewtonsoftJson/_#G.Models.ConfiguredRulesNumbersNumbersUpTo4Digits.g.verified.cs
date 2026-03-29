//HintName: G.Models.ConfiguredRulesNumbersNumbersUpTo4Digits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Numbers Up To 4 Digits
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersNumbersUpTo4Digits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_as_decimal_separator_and_period_as_thousands_separator")]
        UseCommaAsDecimalSeparatorAndPeriodAsThousandsSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_as_decimal_separator_and_space_as_thousands_separator")]
        UseCommaAsDecimalSeparatorAndSpaceAsThousandsSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_as_decimal_separator_period_as_thousands_separator_and_period_for_radio_stations")]
        UseCommaAsDecimalSeparatorPeriodAsThousandsSeparatorAndPeriodForRadioStations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_as_decimal_separator_space_as_thousands_separator_and_period_for_radio_stations")]
        UseCommaAsDecimalSeparatorSpaceAsThousandsSeparatorAndPeriodForRadioStations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_period_as_decimal_separator_and_comma_as_thousands_separator")]
        UsePeriodAsDecimalSeparatorAndCommaAsThousandsSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_period_as_decimal_separator_and_space_as_thousands_separator")]
        UsePeriodAsDecimalSeparatorAndSpaceAsThousandsSeparator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersNumbersUpTo4DigitsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersNumbersUpTo4Digits value)
        {
            return value switch
            {
                ConfiguredRulesNumbersNumbersUpTo4Digits.UseCommaAsDecimalSeparatorAndPeriodAsThousandsSeparator => "use_comma_as_decimal_separator_and_period_as_thousands_separator",
                ConfiguredRulesNumbersNumbersUpTo4Digits.UseCommaAsDecimalSeparatorAndSpaceAsThousandsSeparator => "use_comma_as_decimal_separator_and_space_as_thousands_separator",
                ConfiguredRulesNumbersNumbersUpTo4Digits.UseCommaAsDecimalSeparatorPeriodAsThousandsSeparatorAndPeriodForRadioStations => "use_comma_as_decimal_separator_period_as_thousands_separator_and_period_for_radio_stations",
                ConfiguredRulesNumbersNumbersUpTo4Digits.UseCommaAsDecimalSeparatorSpaceAsThousandsSeparatorAndPeriodForRadioStations => "use_comma_as_decimal_separator_space_as_thousands_separator_and_period_for_radio_stations",
                ConfiguredRulesNumbersNumbersUpTo4Digits.UsePeriodAsDecimalSeparatorAndCommaAsThousandsSeparator => "use_period_as_decimal_separator_and_comma_as_thousands_separator",
                ConfiguredRulesNumbersNumbersUpTo4Digits.UsePeriodAsDecimalSeparatorAndSpaceAsThousandsSeparator => "use_period_as_decimal_separator_and_space_as_thousands_separator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersNumbersUpTo4Digits? ToEnum(string value)
        {
            return value switch
            {
                "use_comma_as_decimal_separator_and_period_as_thousands_separator" => ConfiguredRulesNumbersNumbersUpTo4Digits.UseCommaAsDecimalSeparatorAndPeriodAsThousandsSeparator,
                "use_comma_as_decimal_separator_and_space_as_thousands_separator" => ConfiguredRulesNumbersNumbersUpTo4Digits.UseCommaAsDecimalSeparatorAndSpaceAsThousandsSeparator,
                "use_comma_as_decimal_separator_period_as_thousands_separator_and_period_for_radio_stations" => ConfiguredRulesNumbersNumbersUpTo4Digits.UseCommaAsDecimalSeparatorPeriodAsThousandsSeparatorAndPeriodForRadioStations,
                "use_comma_as_decimal_separator_space_as_thousands_separator_and_period_for_radio_stations" => ConfiguredRulesNumbersNumbersUpTo4Digits.UseCommaAsDecimalSeparatorSpaceAsThousandsSeparatorAndPeriodForRadioStations,
                "use_period_as_decimal_separator_and_comma_as_thousands_separator" => ConfiguredRulesNumbersNumbersUpTo4Digits.UsePeriodAsDecimalSeparatorAndCommaAsThousandsSeparator,
                "use_period_as_decimal_separator_and_space_as_thousands_separator" => ConfiguredRulesNumbersNumbersUpTo4Digits.UsePeriodAsDecimalSeparatorAndSpaceAsThousandsSeparator,
                _ => null,
            };
        }
    }
}