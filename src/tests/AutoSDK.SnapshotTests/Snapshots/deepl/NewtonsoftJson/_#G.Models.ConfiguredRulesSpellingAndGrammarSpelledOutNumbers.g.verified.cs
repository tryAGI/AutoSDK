//HintName: G.Models.ConfiguredRulesSpellingAndGrammarSpelledOutNumbers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Spelled Out Numbers
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarSpelledOutNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_hyphens")]
        UseHyphens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_hyphens_between_elements_under_100_and_not_separated_by_french_word_et")]
        UseHyphensBetweenElementsUnder100AndNotSeparatedByFrenchWordEt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarSpelledOutNumbersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarSpelledOutNumbers value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarSpelledOutNumbers.UseHyphens => "use_hyphens",
                ConfiguredRulesSpellingAndGrammarSpelledOutNumbers.UseHyphensBetweenElementsUnder100AndNotSeparatedByFrenchWordEt => "use_hyphens_between_elements_under_100_and_not_separated_by_french_word_et",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarSpelledOutNumbers? ToEnum(string value)
        {
            return value switch
            {
                "use_hyphens" => ConfiguredRulesSpellingAndGrammarSpelledOutNumbers.UseHyphens,
                "use_hyphens_between_elements_under_100_and_not_separated_by_french_word_et" => ConfiguredRulesSpellingAndGrammarSpelledOutNumbers.UseHyphensBetweenElementsUnder100AndNotSeparatedByFrenchWordEt,
                _ => null,
            };
        }
    }
}