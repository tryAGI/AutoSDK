//HintName: G.Models.ConfiguredRulesSpellingAndGrammarPluralizingForeignWords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Pluralizing Foreign Words
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarPluralizingForeignWords
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_french_spelling_rules")]
        UseFrenchSpellingRules,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_original_language_spelling")]
        UseOriginalLanguageSpelling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarPluralizingForeignWordsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarPluralizingForeignWords value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarPluralizingForeignWords.UseFrenchSpellingRules => "use_french_spelling_rules",
                ConfiguredRulesSpellingAndGrammarPluralizingForeignWords.UseOriginalLanguageSpelling => "use_original_language_spelling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarPluralizingForeignWords? ToEnum(string value)
        {
            return value switch
            {
                "use_french_spelling_rules" => ConfiguredRulesSpellingAndGrammarPluralizingForeignWords.UseFrenchSpellingRules,
                "use_original_language_spelling" => ConfiguredRulesSpellingAndGrammarPluralizingForeignWords.UseOriginalLanguageSpelling,
                _ => null,
            };
        }
    }
}