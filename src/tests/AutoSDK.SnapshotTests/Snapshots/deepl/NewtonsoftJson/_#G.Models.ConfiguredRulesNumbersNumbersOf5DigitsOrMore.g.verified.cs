//HintName: G.Models.ConfiguredRulesNumbersNumbersOf5DigitsOrMore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Numbers Of 5 Digits Or More
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersNumbersOf5DigitsOrMore
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
    public static class ConfiguredRulesNumbersNumbersOf5DigitsOrMoreExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersNumbersOf5DigitsOrMore value)
        {
            return value switch
            {
                ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UseCommaAsDecimalSeparatorAndPeriodAsThousandsSeparator => "use_comma_as_decimal_separator_and_period_as_thousands_separator",
                ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UseCommaAsDecimalSeparatorAndSpaceAsThousandsSeparator => "use_comma_as_decimal_separator_and_space_as_thousands_separator",
                ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UseCommaAsDecimalSeparatorPeriodAsThousandsSeparatorAndPeriodForRadioStations => "use_comma_as_decimal_separator_period_as_thousands_separator_and_period_for_radio_stations",
                ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UseCommaAsDecimalSeparatorSpaceAsThousandsSeparatorAndPeriodForRadioStations => "use_comma_as_decimal_separator_space_as_thousands_separator_and_period_for_radio_stations",
                ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UsePeriodAsDecimalSeparatorAndCommaAsThousandsSeparator => "use_period_as_decimal_separator_and_comma_as_thousands_separator",
                ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UsePeriodAsDecimalSeparatorAndSpaceAsThousandsSeparator => "use_period_as_decimal_separator_and_space_as_thousands_separator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersNumbersOf5DigitsOrMore? ToEnum(string value)
        {
            return value switch
            {
                "use_comma_as_decimal_separator_and_period_as_thousands_separator" => ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UseCommaAsDecimalSeparatorAndPeriodAsThousandsSeparator,
                "use_comma_as_decimal_separator_and_space_as_thousands_separator" => ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UseCommaAsDecimalSeparatorAndSpaceAsThousandsSeparator,
                "use_comma_as_decimal_separator_period_as_thousands_separator_and_period_for_radio_stations" => ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UseCommaAsDecimalSeparatorPeriodAsThousandsSeparatorAndPeriodForRadioStations,
                "use_comma_as_decimal_separator_space_as_thousands_separator_and_period_for_radio_stations" => ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UseCommaAsDecimalSeparatorSpaceAsThousandsSeparatorAndPeriodForRadioStations,
                "use_period_as_decimal_separator_and_comma_as_thousands_separator" => ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UsePeriodAsDecimalSeparatorAndCommaAsThousandsSeparator,
                "use_period_as_decimal_separator_and_space_as_thousands_separator" => ConfiguredRulesNumbersNumbersOf5DigitsOrMore.UsePeriodAsDecimalSeparatorAndSpaceAsThousandsSeparator,
                _ => null,
            };
        }
    }
}