//HintName: G.Models.ConfiguredRulesVocabularyLoanwords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Loanwords
    /// </summary>
    public enum ConfiguredRulesVocabularyLoanwords
    {
        /// <summary>
        /// 
        /// </summary>
        AddExplanationToLoanwordIfDifficultToRephrase,
        /// <summary>
        /// 
        /// </summary>
        RephraseLoanwordInDailyUseChineseOrJapaneseWordsIfPossible,
        /// <summary>
        /// 
        /// </summary>
        RephraseLoanwordWithAnotherExpressionIfNotEstablished,
        /// <summary>
        /// 
        /// </summary>
        UseLoanwordAsIsIfWellEstablished,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesVocabularyLoanwordsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesVocabularyLoanwords value)
        {
            return value switch
            {
                ConfiguredRulesVocabularyLoanwords.AddExplanationToLoanwordIfDifficultToRephrase => "add_explanation_to_loanword_if_difficult_to_rephrase",
                ConfiguredRulesVocabularyLoanwords.RephraseLoanwordInDailyUseChineseOrJapaneseWordsIfPossible => "rephrase_loanword_in_daily_use_chinese_or_japanese_words_if_possible",
                ConfiguredRulesVocabularyLoanwords.RephraseLoanwordWithAnotherExpressionIfNotEstablished => "rephrase_loanword_with_another_expression_if_not_established",
                ConfiguredRulesVocabularyLoanwords.UseLoanwordAsIsIfWellEstablished => "use_loanword_as_is_if_well_established",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesVocabularyLoanwords? ToEnum(string value)
        {
            return value switch
            {
                "add_explanation_to_loanword_if_difficult_to_rephrase" => ConfiguredRulesVocabularyLoanwords.AddExplanationToLoanwordIfDifficultToRephrase,
                "rephrase_loanword_in_daily_use_chinese_or_japanese_words_if_possible" => ConfiguredRulesVocabularyLoanwords.RephraseLoanwordInDailyUseChineseOrJapaneseWordsIfPossible,
                "rephrase_loanword_with_another_expression_if_not_established" => ConfiguredRulesVocabularyLoanwords.RephraseLoanwordWithAnotherExpressionIfNotEstablished,
                "use_loanword_as_is_if_well_established" => ConfiguredRulesVocabularyLoanwords.UseLoanwordAsIsIfWellEstablished,
                _ => null,
            };
        }
    }
}