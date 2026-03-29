//HintName: G.Models.ConfiguredRulesPunctuationQuotationMark.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Quotation Mark
    /// </summary>
    public enum ConfiguredRulesPunctuationQuotationMark
    {
        /// <summary>
        /// 
        /// </summary>
        UseCurlyQuotationMarks,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleCurlyQuotationMarks,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleStraightQuotationMarks,
        /// <summary>
        /// 
        /// </summary>
        UseGuillemets,
        /// <summary>
        /// 
        /// </summary>
        UseStraightQuotationMarks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationQuotationMarkExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationQuotationMark value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationQuotationMark.UseCurlyQuotationMarks => "use_curly_quotation_marks",
                ConfiguredRulesPunctuationQuotationMark.UseDoubleCurlyQuotationMarks => "use_double_curly_quotation_marks",
                ConfiguredRulesPunctuationQuotationMark.UseDoubleStraightQuotationMarks => "use_double_straight_quotation_marks",
                ConfiguredRulesPunctuationQuotationMark.UseGuillemets => "use_guillemets",
                ConfiguredRulesPunctuationQuotationMark.UseStraightQuotationMarks => "use_straight_quotation_marks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationQuotationMark? ToEnum(string value)
        {
            return value switch
            {
                "use_curly_quotation_marks" => ConfiguredRulesPunctuationQuotationMark.UseCurlyQuotationMarks,
                "use_double_curly_quotation_marks" => ConfiguredRulesPunctuationQuotationMark.UseDoubleCurlyQuotationMarks,
                "use_double_straight_quotation_marks" => ConfiguredRulesPunctuationQuotationMark.UseDoubleStraightQuotationMarks,
                "use_guillemets" => ConfiguredRulesPunctuationQuotationMark.UseGuillemets,
                "use_straight_quotation_marks" => ConfiguredRulesPunctuationQuotationMark.UseStraightQuotationMarks,
                _ => null,
            };
        }
    }
}