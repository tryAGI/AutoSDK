//HintName: G.Models.ConfiguredRulesNumbersThousandsSeparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Thousands Separator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersThousandsSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use")]
        DoNotUse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_thousands_separator")]
        DoNotUseThousandsSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma")]
        UseComma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma_to_separate_large_numbers_into_units_of_three")]
        UseCommaToSeparateLargeNumbersIntoUnitsOfThree,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_period")]
        UsePeriod,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_period_as_thousands_separator")]
        UsePeriodAsThousandsSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_space")]
        UseSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_space_as_thousands_separator")]
        UseSpaceAsThousandsSeparator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_space_to_separate_large_numbers_into_units_of_three")]
        UseSpaceToSeparateLargeNumbersIntoUnitsOfThree,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_straight_apostrophe_as_thousands_separator")]
        UseStraightApostropheAsThousandsSeparator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersThousandsSeparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersThousandsSeparator value)
        {
            return value switch
            {
                ConfiguredRulesNumbersThousandsSeparator.DoNotUse => "do_not_use",
                ConfiguredRulesNumbersThousandsSeparator.DoNotUseThousandsSeparator => "do_not_use_thousands_separator",
                ConfiguredRulesNumbersThousandsSeparator.UseComma => "use_comma",
                ConfiguredRulesNumbersThousandsSeparator.UseCommaToSeparateLargeNumbersIntoUnitsOfThree => "use_comma_to_separate_large_numbers_into_units_of_three",
                ConfiguredRulesNumbersThousandsSeparator.UsePeriod => "use_period",
                ConfiguredRulesNumbersThousandsSeparator.UsePeriodAsThousandsSeparator => "use_period_as_thousands_separator",
                ConfiguredRulesNumbersThousandsSeparator.UseSpace => "use_space",
                ConfiguredRulesNumbersThousandsSeparator.UseSpaceAsThousandsSeparator => "use_space_as_thousands_separator",
                ConfiguredRulesNumbersThousandsSeparator.UseSpaceToSeparateLargeNumbersIntoUnitsOfThree => "use_space_to_separate_large_numbers_into_units_of_three",
                ConfiguredRulesNumbersThousandsSeparator.UseStraightApostropheAsThousandsSeparator => "use_straight_apostrophe_as_thousands_separator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersThousandsSeparator? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesNumbersThousandsSeparator.DoNotUse,
                "do_not_use_thousands_separator" => ConfiguredRulesNumbersThousandsSeparator.DoNotUseThousandsSeparator,
                "use_comma" => ConfiguredRulesNumbersThousandsSeparator.UseComma,
                "use_comma_to_separate_large_numbers_into_units_of_three" => ConfiguredRulesNumbersThousandsSeparator.UseCommaToSeparateLargeNumbersIntoUnitsOfThree,
                "use_period" => ConfiguredRulesNumbersThousandsSeparator.UsePeriod,
                "use_period_as_thousands_separator" => ConfiguredRulesNumbersThousandsSeparator.UsePeriodAsThousandsSeparator,
                "use_space" => ConfiguredRulesNumbersThousandsSeparator.UseSpace,
                "use_space_as_thousands_separator" => ConfiguredRulesNumbersThousandsSeparator.UseSpaceAsThousandsSeparator,
                "use_space_to_separate_large_numbers_into_units_of_three" => ConfiguredRulesNumbersThousandsSeparator.UseSpaceToSeparateLargeNumbersIntoUnitsOfThree,
                "use_straight_apostrophe_as_thousands_separator" => ConfiguredRulesNumbersThousandsSeparator.UseStraightApostropheAsThousandsSeparator,
                _ => null,
            };
        }
    }
}