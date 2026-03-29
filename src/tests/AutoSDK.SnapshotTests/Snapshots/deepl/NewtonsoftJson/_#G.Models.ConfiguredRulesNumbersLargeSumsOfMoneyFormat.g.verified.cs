//HintName: G.Models.ConfiguredRulesNumbersLargeSumsOfMoneyFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Large Sums Of Money Format
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersLargeSumsOfMoneyFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_abbreviation_for_million_or_billion_without_space")]
        UseAmountFollowedByAbbreviationForMillionOrBillionWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_space_then_abbreviation_for_million_or_billion")]
        UseAmountFollowedBySpaceThenAbbreviationForMillionOrBillion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_amount_followed_by_space_then_english_word_million_or_billion")]
        UseAmountFollowedBySpaceThenEnglishWordMillionOrBillion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersLargeSumsOfMoneyFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersLargeSumsOfMoneyFormat value)
        {
            return value switch
            {
                ConfiguredRulesNumbersLargeSumsOfMoneyFormat.UseAmountFollowedByAbbreviationForMillionOrBillionWithoutSpace => "use_amount_followed_by_abbreviation_for_million_or_billion_without_space",
                ConfiguredRulesNumbersLargeSumsOfMoneyFormat.UseAmountFollowedBySpaceThenAbbreviationForMillionOrBillion => "use_amount_followed_by_space_then_abbreviation_for_million_or_billion",
                ConfiguredRulesNumbersLargeSumsOfMoneyFormat.UseAmountFollowedBySpaceThenEnglishWordMillionOrBillion => "use_amount_followed_by_space_then_english_word_million_or_billion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersLargeSumsOfMoneyFormat? ToEnum(string value)
        {
            return value switch
            {
                "use_amount_followed_by_abbreviation_for_million_or_billion_without_space" => ConfiguredRulesNumbersLargeSumsOfMoneyFormat.UseAmountFollowedByAbbreviationForMillionOrBillionWithoutSpace,
                "use_amount_followed_by_space_then_abbreviation_for_million_or_billion" => ConfiguredRulesNumbersLargeSumsOfMoneyFormat.UseAmountFollowedBySpaceThenAbbreviationForMillionOrBillion,
                "use_amount_followed_by_space_then_english_word_million_or_billion" => ConfiguredRulesNumbersLargeSumsOfMoneyFormat.UseAmountFollowedBySpaceThenEnglishWordMillionOrBillion,
                _ => null,
            };
        }
    }
}