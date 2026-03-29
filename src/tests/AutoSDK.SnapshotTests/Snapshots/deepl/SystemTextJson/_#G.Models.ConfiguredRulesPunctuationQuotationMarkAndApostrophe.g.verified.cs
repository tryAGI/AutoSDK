//HintName: G.Models.ConfiguredRulesPunctuationQuotationMarkAndApostrophe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Quotation Mark And Apostrophe
    /// </summary>
    public enum ConfiguredRulesPunctuationQuotationMarkAndApostrophe
    {
        /// <summary>
        /// 
        /// </summary>
        UseCurlyQuotationMarksAndApostrophes,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleAndSingleCurlyQuotationMarksAndCurlyApostrophes,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleAndSingleStraightQuotationMarksAndStraightApostrophes,
        /// <summary>
        /// 
        /// </summary>
        UseGuillemetsAndCurlyApostrophes,
        /// <summary>
        /// 
        /// </summary>
        UseGuillemetsAndStraightApostrophes,
        /// <summary>
        /// 
        /// </summary>
        UseStraightQuotationMarksAndApostrophes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationQuotationMarkAndApostropheExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationQuotationMarkAndApostrophe value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseCurlyQuotationMarksAndApostrophes => "use_curly_quotation_marks_and_apostrophes",
                ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseDoubleAndSingleCurlyQuotationMarksAndCurlyApostrophes => "use_double_and_single_curly_quotation_marks_and_curly_apostrophes",
                ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseDoubleAndSingleStraightQuotationMarksAndStraightApostrophes => "use_double_and_single_straight_quotation_marks_and_straight_apostrophes",
                ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseGuillemetsAndCurlyApostrophes => "use_guillemets_and_curly_apostrophes",
                ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseGuillemetsAndStraightApostrophes => "use_guillemets_and_straight_apostrophes",
                ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseStraightQuotationMarksAndApostrophes => "use_straight_quotation_marks_and_apostrophes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationQuotationMarkAndApostrophe? ToEnum(string value)
        {
            return value switch
            {
                "use_curly_quotation_marks_and_apostrophes" => ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseCurlyQuotationMarksAndApostrophes,
                "use_double_and_single_curly_quotation_marks_and_curly_apostrophes" => ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseDoubleAndSingleCurlyQuotationMarksAndCurlyApostrophes,
                "use_double_and_single_straight_quotation_marks_and_straight_apostrophes" => ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseDoubleAndSingleStraightQuotationMarksAndStraightApostrophes,
                "use_guillemets_and_curly_apostrophes" => ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseGuillemetsAndCurlyApostrophes,
                "use_guillemets_and_straight_apostrophes" => ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseGuillemetsAndStraightApostrophes,
                "use_straight_quotation_marks_and_apostrophes" => ConfiguredRulesPunctuationQuotationMarkAndApostrophe.UseStraightQuotationMarksAndApostrophes,
                _ => null,
            };
        }
    }
}