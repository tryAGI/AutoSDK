//HintName: G.Models.ConfiguredRulesSpellingAndGrammarConjunctions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Conjunctions
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarConjunctions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="never_start_sentence_with_coordinating_conjunction")]
        NeverStartSentenceWithCoordinatingConjunction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarConjunctionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarConjunctions value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarConjunctions.NeverStartSentenceWithCoordinatingConjunction => "never_start_sentence_with_coordinating_conjunction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarConjunctions? ToEnum(string value)
        {
            return value switch
            {
                "never_start_sentence_with_coordinating_conjunction" => ConfiguredRulesSpellingAndGrammarConjunctions.NeverStartSentenceWithCoordinatingConjunction,
                _ => null,
            };
        }
    }
}