//HintName: G.Models.ConfiguredRulesNumbersDecimalSeparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Decimal Separator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersDecimalSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_and_do_not_use_thousands_separator")]
        UseCommaAndDoNotUseThousandsSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_as_decimal_separator")]
        UseCommaAsDecimalSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_do_not_use_thousands_separator_and_use_period_only_for_radio_stations")]
        UseCommaDoNotUseThousandsSeparatorAndUsePeriodOnlyForRadioStations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_period_and_do_not_use_thousands_separator")]
        UsePeriodAndDoNotUseThousandsSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_period_as_decimal_separator")]
        UsePeriodAsDecimalSeparator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersDecimalSeparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersDecimalSeparator value)
        {
            return value switch
            {
                ConfiguredRulesNumbersDecimalSeparator.UseCommaAndDoNotUseThousandsSeparator => "use_comma_and_do_not_use_thousands_separator",
                ConfiguredRulesNumbersDecimalSeparator.UseCommaAsDecimalSeparator => "use_comma_as_decimal_separator",
                ConfiguredRulesNumbersDecimalSeparator.UseCommaDoNotUseThousandsSeparatorAndUsePeriodOnlyForRadioStations => "use_comma_do_not_use_thousands_separator_and_use_period_only_for_radio_stations",
                ConfiguredRulesNumbersDecimalSeparator.UsePeriodAndDoNotUseThousandsSeparator => "use_period_and_do_not_use_thousands_separator",
                ConfiguredRulesNumbersDecimalSeparator.UsePeriodAsDecimalSeparator => "use_period_as_decimal_separator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersDecimalSeparator? ToEnum(string value)
        {
            return value switch
            {
                "use_comma_and_do_not_use_thousands_separator" => ConfiguredRulesNumbersDecimalSeparator.UseCommaAndDoNotUseThousandsSeparator,
                "use_comma_as_decimal_separator" => ConfiguredRulesNumbersDecimalSeparator.UseCommaAsDecimalSeparator,
                "use_comma_do_not_use_thousands_separator_and_use_period_only_for_radio_stations" => ConfiguredRulesNumbersDecimalSeparator.UseCommaDoNotUseThousandsSeparatorAndUsePeriodOnlyForRadioStations,
                "use_period_and_do_not_use_thousands_separator" => ConfiguredRulesNumbersDecimalSeparator.UsePeriodAndDoNotUseThousandsSeparator,
                "use_period_as_decimal_separator" => ConfiguredRulesNumbersDecimalSeparator.UsePeriodAsDecimalSeparator,
                _ => null,
            };
        }
    }
}