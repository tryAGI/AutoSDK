//HintName: G.Models.ConfiguredRulesPunctuationQuotationStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Quotation Style
    /// </summary>
    public enum ConfiguredRulesPunctuationQuotationStyle
    {
        /// <summary>
        /// 
        /// </summary>
        UseCornerBracketsForPrimaryQuotationsAndDoubleCornerBracketsForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleCurlyQuotationMarksForPrimaryQuotationsAndSingleCurlyQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleCurlyQuotationMarksForPrimaryQuotationsThenAlternateWithSingleCurlyQuotationMarksForNestedQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleGermanQuotationMarksForPrimaryQuotationsAndSingleGermanQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleQuotationMarksForPrimaryQuotationsAndSingleQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleStraightQuotationMarksForPrimaryQuotationsAndSingleStraightQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseDoubleStraightQuotationMarksForPrimaryQuotationsThenAlternateWithSingleStraightQuotationMarksForNestedQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseGuillemetsForPrimaryQuotationsAndDoubleCurlyQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseGuillemetsForPrimaryQuotationsAndDoubleStraightQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseGuillemetsForPrimaryQuotationsAndSingleGuillemetsForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseGuillemetsForPrimaryQuotationsDoubleCurlyQuotationMarksForSecondaryQuotationsAndSingleCurlyQuotationMarksForFurtherNestedQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseReversedGuillemetsForPrimaryQuotationsAndSingleReversedGuillemetsForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        UseSingleQuotationMarksForPrimaryQuotationsAndDoubleQuotationMarksForSecondaryQuotations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationQuotationStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationQuotationStyle value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationQuotationStyle.UseCornerBracketsForPrimaryQuotationsAndDoubleCornerBracketsForSecondaryQuotations => "use_corner_brackets_for_primary_quotations_and_double_corner_brackets_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseDoubleCurlyQuotationMarksForPrimaryQuotationsAndSingleCurlyQuotationMarksForSecondaryQuotations => "use_double_curly_quotation_marks_for_primary_quotations_and_single_curly_quotation_marks_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseDoubleCurlyQuotationMarksForPrimaryQuotationsThenAlternateWithSingleCurlyQuotationMarksForNestedQuotations => "use_double_curly_quotation_marks_for_primary_quotations_then_alternate_with_single_curly_quotation_marks_for_nested_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseDoubleGermanQuotationMarksForPrimaryQuotationsAndSingleGermanQuotationMarksForSecondaryQuotations => "use_double_german_quotation_marks_for_primary_quotations_and_single_german_quotation_marks_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseDoubleQuotationMarksForPrimaryQuotationsAndSingleQuotationMarksForSecondaryQuotations => "use_double_quotation_marks_for_primary_quotations_and_single_quotation_marks_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseDoubleStraightQuotationMarksForPrimaryQuotationsAndSingleStraightQuotationMarksForSecondaryQuotations => "use_double_straight_quotation_marks_for_primary_quotations_and_single_straight_quotation_marks_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseDoubleStraightQuotationMarksForPrimaryQuotationsThenAlternateWithSingleStraightQuotationMarksForNestedQuotations => "use_double_straight_quotation_marks_for_primary_quotations_then_alternate_with_single_straight_quotation_marks_for_nested_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseGuillemetsForPrimaryQuotationsAndDoubleCurlyQuotationMarksForSecondaryQuotations => "use_guillemets_for_primary_quotations_and_double_curly_quotation_marks_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseGuillemetsForPrimaryQuotationsAndDoubleStraightQuotationMarksForSecondaryQuotations => "use_guillemets_for_primary_quotations_and_double_straight_quotation_marks_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseGuillemetsForPrimaryQuotationsAndSingleGuillemetsForSecondaryQuotations => "use_guillemets_for_primary_quotations_and_single_guillemets_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseGuillemetsForPrimaryQuotationsDoubleCurlyQuotationMarksForSecondaryQuotationsAndSingleCurlyQuotationMarksForFurtherNestedQuotations => "use_guillemets_for_primary_quotations_double_curly_quotation_marks_for_secondary_quotations_and_single_curly_quotation_marks_for_further_nested_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseReversedGuillemetsForPrimaryQuotationsAndSingleReversedGuillemetsForSecondaryQuotations => "use_reversed_guillemets_for_primary_quotations_and_single_reversed_guillemets_for_secondary_quotations",
                ConfiguredRulesPunctuationQuotationStyle.UseSingleQuotationMarksForPrimaryQuotationsAndDoubleQuotationMarksForSecondaryQuotations => "use_single_quotation_marks_for_primary_quotations_and_double_quotation_marks_for_secondary_quotations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationQuotationStyle? ToEnum(string value)
        {
            return value switch
            {
                "use_corner_brackets_for_primary_quotations_and_double_corner_brackets_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseCornerBracketsForPrimaryQuotationsAndDoubleCornerBracketsForSecondaryQuotations,
                "use_double_curly_quotation_marks_for_primary_quotations_and_single_curly_quotation_marks_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseDoubleCurlyQuotationMarksForPrimaryQuotationsAndSingleCurlyQuotationMarksForSecondaryQuotations,
                "use_double_curly_quotation_marks_for_primary_quotations_then_alternate_with_single_curly_quotation_marks_for_nested_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseDoubleCurlyQuotationMarksForPrimaryQuotationsThenAlternateWithSingleCurlyQuotationMarksForNestedQuotations,
                "use_double_german_quotation_marks_for_primary_quotations_and_single_german_quotation_marks_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseDoubleGermanQuotationMarksForPrimaryQuotationsAndSingleGermanQuotationMarksForSecondaryQuotations,
                "use_double_quotation_marks_for_primary_quotations_and_single_quotation_marks_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseDoubleQuotationMarksForPrimaryQuotationsAndSingleQuotationMarksForSecondaryQuotations,
                "use_double_straight_quotation_marks_for_primary_quotations_and_single_straight_quotation_marks_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseDoubleStraightQuotationMarksForPrimaryQuotationsAndSingleStraightQuotationMarksForSecondaryQuotations,
                "use_double_straight_quotation_marks_for_primary_quotations_then_alternate_with_single_straight_quotation_marks_for_nested_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseDoubleStraightQuotationMarksForPrimaryQuotationsThenAlternateWithSingleStraightQuotationMarksForNestedQuotations,
                "use_guillemets_for_primary_quotations_and_double_curly_quotation_marks_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseGuillemetsForPrimaryQuotationsAndDoubleCurlyQuotationMarksForSecondaryQuotations,
                "use_guillemets_for_primary_quotations_and_double_straight_quotation_marks_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseGuillemetsForPrimaryQuotationsAndDoubleStraightQuotationMarksForSecondaryQuotations,
                "use_guillemets_for_primary_quotations_and_single_guillemets_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseGuillemetsForPrimaryQuotationsAndSingleGuillemetsForSecondaryQuotations,
                "use_guillemets_for_primary_quotations_double_curly_quotation_marks_for_secondary_quotations_and_single_curly_quotation_marks_for_further_nested_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseGuillemetsForPrimaryQuotationsDoubleCurlyQuotationMarksForSecondaryQuotationsAndSingleCurlyQuotationMarksForFurtherNestedQuotations,
                "use_reversed_guillemets_for_primary_quotations_and_single_reversed_guillemets_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseReversedGuillemetsForPrimaryQuotationsAndSingleReversedGuillemetsForSecondaryQuotations,
                "use_single_quotation_marks_for_primary_quotations_and_double_quotation_marks_for_secondary_quotations" => ConfiguredRulesPunctuationQuotationStyle.UseSingleQuotationMarksForPrimaryQuotationsAndDoubleQuotationMarksForSecondaryQuotations,
                _ => null,
            };
        }
    }
}