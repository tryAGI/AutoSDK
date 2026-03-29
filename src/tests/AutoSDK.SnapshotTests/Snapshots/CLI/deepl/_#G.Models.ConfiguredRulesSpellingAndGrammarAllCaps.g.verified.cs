//HintName: G.Models.ConfiguredRulesSpellingAndGrammarAllCaps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for All Caps
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarAllCaps
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseAllCapsExceptForAcronymsInitialismsOrProperNouns,
        /// <summary>
        /// 
        /// </summary>
        DoNotUseAllCapsExceptForAcronymsOrBrandNames,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarAllCapsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarAllCaps value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarAllCaps.DoNotUseAllCapsExceptForAcronymsInitialismsOrProperNouns => "do_not_use_all_caps_except_for_acronyms_initialisms_or_proper_nouns",
                ConfiguredRulesSpellingAndGrammarAllCaps.DoNotUseAllCapsExceptForAcronymsOrBrandNames => "do_not_use_all_caps_except_for_acronyms_or_brand_names",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarAllCaps? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_all_caps_except_for_acronyms_initialisms_or_proper_nouns" => ConfiguredRulesSpellingAndGrammarAllCaps.DoNotUseAllCapsExceptForAcronymsInitialismsOrProperNouns,
                "do_not_use_all_caps_except_for_acronyms_or_brand_names" => ConfiguredRulesSpellingAndGrammarAllCaps.DoNotUseAllCapsExceptForAcronymsOrBrandNames,
                _ => null,
            };
        }
    }
}