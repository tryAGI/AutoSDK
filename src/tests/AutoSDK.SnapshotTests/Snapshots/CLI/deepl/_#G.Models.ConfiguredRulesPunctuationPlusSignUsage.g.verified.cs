//HintName: G.Models.ConfiguredRulesPunctuationPlusSignUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Plus Sign Usage
    /// </summary>
    public enum ConfiguredRulesPunctuationPlusSignUsage
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUsePlusSignToSymbolizeEnglishWordAndUnlessItIsPartOfAProperNoun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationPlusSignUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationPlusSignUsage value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationPlusSignUsage.DoNotUsePlusSignToSymbolizeEnglishWordAndUnlessItIsPartOfAProperNoun => "do_not_use_plus_sign_to_symbolize_english_word_and_unless_it_is_part_of_a_proper_noun",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationPlusSignUsage? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_plus_sign_to_symbolize_english_word_and_unless_it_is_part_of_a_proper_noun" => ConfiguredRulesPunctuationPlusSignUsage.DoNotUsePlusSignToSymbolizeEnglishWordAndUnlessItIsPartOfAProperNoun,
                _ => null,
            };
        }
    }
}