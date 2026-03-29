//HintName: G.Models.ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Accents In Verbs Conjugated Like French Word Céder
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_acute_accent")]
        UseAcuteAccent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_grave_accent")]
        UseGraveAccent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer.UseAcuteAccent => "use_acute_accent",
                ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer.UseGraveAccent => "use_grave_accent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer? ToEnum(string value)
        {
            return value switch
            {
                "use_acute_accent" => ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer.UseAcuteAccent,
                "use_grave_accent" => ConfiguredRulesSpellingAndGrammarAccentsInVerbsConjugatedLikeFrenchWordCDer.UseGraveAccent,
                _ => null,
            };
        }
    }
}