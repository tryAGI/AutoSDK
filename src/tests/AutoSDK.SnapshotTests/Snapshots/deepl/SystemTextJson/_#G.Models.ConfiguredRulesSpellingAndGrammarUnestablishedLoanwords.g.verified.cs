//HintName: G.Models.ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Unestablished Loanwords
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords
    {
        /// <summary>
        /// 
        /// </summary>
        ParaphraseInKorean,
        /// <summary>
        /// 
        /// </summary>
        UseAsIs,
        /// <summary>
        /// 
        /// </summary>
        UseAsIsWithExplanationInParentheses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarUnestablishedLoanwordsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords.ParaphraseInKorean => "paraphrase_in_korean",
                ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords.UseAsIs => "use_as_is",
                ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords.UseAsIsWithExplanationInParentheses => "use_as_is_with_explanation_in_parentheses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords? ToEnum(string value)
        {
            return value switch
            {
                "paraphrase_in_korean" => ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords.ParaphraseInKorean,
                "use_as_is" => ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords.UseAsIs,
                "use_as_is_with_explanation_in_parentheses" => ConfiguredRulesSpellingAndGrammarUnestablishedLoanwords.UseAsIsWithExplanationInParentheses,
                _ => null,
            };
        }
    }
}