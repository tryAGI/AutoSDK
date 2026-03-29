//HintName: G.Models.ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Past Participle Of French Word Laisser Followed By Infinitive
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive
    {
        /// <summary>
        /// 
        /// </summary>
        MakeFrenchWordLaisserAgreeWithDirectObjectComplementIfItAppearsBeforeVerb,
        /// <summary>
        /// 
        /// </summary>
        UseInvariableFormFrenchWordLaiss_,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitiveExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive.MakeFrenchWordLaisserAgreeWithDirectObjectComplementIfItAppearsBeforeVerb => "make_french_word_laisser_agree_with_direct_object_complement_if_it_appears_before_verb",
                ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive.UseInvariableFormFrenchWordLaiss_ => "use_invariable_form_french_word_laissé",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive? ToEnum(string value)
        {
            return value switch
            {
                "make_french_word_laisser_agree_with_direct_object_complement_if_it_appears_before_verb" => ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive.MakeFrenchWordLaisserAgreeWithDirectObjectComplementIfItAppearsBeforeVerb,
                "use_invariable_form_french_word_laissé" => ConfiguredRulesSpellingAndGrammarPastParticipleOfFrenchWordLaisserFollowedByInfinitive.UseInvariableFormFrenchWordLaiss_,
                _ => null,
            };
        }
    }
}