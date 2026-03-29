//HintName: G.Models.ConfiguredRulesPunctuationHighlightingSpecificExpressions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Highlighting Specific Expressions
    /// </summary>
    public enum ConfiguredRulesPunctuationHighlightingSpecificExpressions
    {
        /// <summary>
        /// 
        /// </summary>
        UseSingleCurlyQuotationMarks,
        /// <summary>
        /// 
        /// </summary>
        UseSingleStraightQuotationMarks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationHighlightingSpecificExpressionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationHighlightingSpecificExpressions value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationHighlightingSpecificExpressions.UseSingleCurlyQuotationMarks => "use_single_curly_quotation_marks",
                ConfiguredRulesPunctuationHighlightingSpecificExpressions.UseSingleStraightQuotationMarks => "use_single_straight_quotation_marks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationHighlightingSpecificExpressions? ToEnum(string value)
        {
            return value switch
            {
                "use_single_curly_quotation_marks" => ConfiguredRulesPunctuationHighlightingSpecificExpressions.UseSingleCurlyQuotationMarks,
                "use_single_straight_quotation_marks" => ConfiguredRulesPunctuationHighlightingSpecificExpressions.UseSingleStraightQuotationMarks,
                _ => null,
            };
        }
    }
}