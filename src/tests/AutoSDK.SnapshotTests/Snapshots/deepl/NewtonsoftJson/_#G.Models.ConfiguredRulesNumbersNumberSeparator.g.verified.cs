//HintName: G.Models.ConfiguredRulesNumbersNumberSeparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Number Separator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersNumberSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_chinese_comma_to_separate_numbers_indicating_approximate_value")]
        DoNotUseChineseCommaToSeparateNumbersIndicatingApproximateValue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_chinese_comma_to_separate_numbers_in_abbreviations")]
        UseChineseCommaToSeparateNumbersInAbbreviations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersNumberSeparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersNumberSeparator value)
        {
            return value switch
            {
                ConfiguredRulesNumbersNumberSeparator.DoNotUseChineseCommaToSeparateNumbersIndicatingApproximateValue => "do_not_use_chinese_comma_to_separate_numbers_indicating_approximate_value",
                ConfiguredRulesNumbersNumberSeparator.UseChineseCommaToSeparateNumbersInAbbreviations => "use_chinese_comma_to_separate_numbers_in_abbreviations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersNumberSeparator? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_chinese_comma_to_separate_numbers_indicating_approximate_value" => ConfiguredRulesNumbersNumberSeparator.DoNotUseChineseCommaToSeparateNumbersIndicatingApproximateValue,
                "use_chinese_comma_to_separate_numbers_in_abbreviations" => ConfiguredRulesNumbersNumberSeparator.UseChineseCommaToSeparateNumbersInAbbreviations,
                _ => null,
            };
        }
    }
}