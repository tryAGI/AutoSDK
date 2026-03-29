//HintName: G.Models.ConfiguredRulesSpellingAndGrammarQuotationModification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Quotation Modification
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarQuotationModification
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotModifyTextInQuotationMarks,
        /// <summary>
        /// 
        /// </summary>
        ModifyTextInQuotationMarksAccordingToCustomRules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarQuotationModificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarQuotationModification value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarQuotationModification.DoNotModifyTextInQuotationMarks => "do_not_modify_text_in_quotation_marks",
                ConfiguredRulesSpellingAndGrammarQuotationModification.ModifyTextInQuotationMarksAccordingToCustomRules => "modify_text_in_quotation_marks_according_to_custom_rules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarQuotationModification? ToEnum(string value)
        {
            return value switch
            {
                "do_not_modify_text_in_quotation_marks" => ConfiguredRulesSpellingAndGrammarQuotationModification.DoNotModifyTextInQuotationMarks,
                "modify_text_in_quotation_marks_according_to_custom_rules" => ConfiguredRulesSpellingAndGrammarQuotationModification.ModifyTextInQuotationMarksAccordingToCustomRules,
                _ => null,
            };
        }
    }
}