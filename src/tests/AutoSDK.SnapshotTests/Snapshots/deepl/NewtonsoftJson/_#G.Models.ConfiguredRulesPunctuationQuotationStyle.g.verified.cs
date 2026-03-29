//HintName: G.Models.ConfiguredRulesPunctuationQuotationStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Quotation Style
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationQuotationStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_corner_brackets_for_primary_quotations_and_double_corner_brackets_for_secondary_quotations")]
        UseCornerBracketsForPrimaryQuotationsAndDoubleCornerBracketsForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_curly_quotation_marks_for_primary_quotations_and_single_curly_quotation_marks_for_secondary_quotations")]
        UseDoubleCurlyQuotationMarksForPrimaryQuotationsAndSingleCurlyQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_curly_quotation_marks_for_primary_quotations_then_alternate_with_single_curly_quotation_marks_for_nested_quotations")]
        UseDoubleCurlyQuotationMarksForPrimaryQuotationsThenAlternateWithSingleCurlyQuotationMarksForNestedQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_german_quotation_marks_for_primary_quotations_and_single_german_quotation_marks_for_secondary_quotations")]
        UseDoubleGermanQuotationMarksForPrimaryQuotationsAndSingleGermanQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_quotation_marks_for_primary_quotations_and_single_quotation_marks_for_secondary_quotations")]
        UseDoubleQuotationMarksForPrimaryQuotationsAndSingleQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_straight_quotation_marks_for_primary_quotations_and_single_straight_quotation_marks_for_secondary_quotations")]
        UseDoubleStraightQuotationMarksForPrimaryQuotationsAndSingleStraightQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_straight_quotation_marks_for_primary_quotations_then_alternate_with_single_straight_quotation_marks_for_nested_quotations")]
        UseDoubleStraightQuotationMarksForPrimaryQuotationsThenAlternateWithSingleStraightQuotationMarksForNestedQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_guillemets_for_primary_quotations_and_double_curly_quotation_marks_for_secondary_quotations")]
        UseGuillemetsForPrimaryQuotationsAndDoubleCurlyQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_guillemets_for_primary_quotations_and_double_straight_quotation_marks_for_secondary_quotations")]
        UseGuillemetsForPrimaryQuotationsAndDoubleStraightQuotationMarksForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_guillemets_for_primary_quotations_and_single_guillemets_for_secondary_quotations")]
        UseGuillemetsForPrimaryQuotationsAndSingleGuillemetsForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_guillemets_for_primary_quotations_double_curly_quotation_marks_for_secondary_quotations_and_single_curly_quotation_marks_for_further_nested_quotations")]
        UseGuillemetsForPrimaryQuotationsDoubleCurlyQuotationMarksForSecondaryQuotationsAndSingleCurlyQuotationMarksForFurtherNestedQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_reversed_guillemets_for_primary_quotations_and_single_reversed_guillemets_for_secondary_quotations")]
        UseReversedGuillemetsForPrimaryQuotationsAndSingleReversedGuillemetsForSecondaryQuotations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_single_quotation_marks_for_primary_quotations_and_double_quotation_marks_for_secondary_quotations")]
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