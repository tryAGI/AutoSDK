//HintName: G.Models.ConfiguredRulesSpellingAndGrammarEstablishedLoanwords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Established Loanwords
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarEstablishedLoanwords
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_as_is")]
        UseAsIs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_native_or_sino_korean_equivalents")]
        UseNativeOrSinoKoreanEquivalents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarEstablishedLoanwordsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarEstablishedLoanwords value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarEstablishedLoanwords.UseAsIs => "use_as_is",
                ConfiguredRulesSpellingAndGrammarEstablishedLoanwords.UseNativeOrSinoKoreanEquivalents => "use_native_or_sino_korean_equivalents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarEstablishedLoanwords? ToEnum(string value)
        {
            return value switch
            {
                "use_as_is" => ConfiguredRulesSpellingAndGrammarEstablishedLoanwords.UseAsIs,
                "use_native_or_sino_korean_equivalents" => ConfiguredRulesSpellingAndGrammarEstablishedLoanwords.UseNativeOrSinoKoreanEquivalents,
                _ => null,
            };
        }
    }
}