//HintName: G.Models.ConfiguredRulesPunctuationAmpersandUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Ampersand Usage
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationAmpersandUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_english_word_and_except_in_company_names_common_abbreviations_titles_software_code_and_mathematical_equations")]
        UseEnglishWordAndExceptInCompanyNamesCommonAbbreviationsTitlesSoftwareCodeAndMathematicalEquations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_ampersand")]
        UseFullWidthAmpersand,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_german_word_und_except_in_company_names_common_abbreviations_titles_software_code_and_mathematical_equations")]
        UseGermanWordUndExceptInCompanyNamesCommonAbbreviationsTitlesSoftwareCodeAndMathematicalEquations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_half_width_ampersand")]
        UseHalfWidthAmpersand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationAmpersandUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationAmpersandUsage value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationAmpersandUsage.UseEnglishWordAndExceptInCompanyNamesCommonAbbreviationsTitlesSoftwareCodeAndMathematicalEquations => "use_english_word_and_except_in_company_names_common_abbreviations_titles_software_code_and_mathematical_equations",
                ConfiguredRulesPunctuationAmpersandUsage.UseFullWidthAmpersand => "use_full_width_ampersand",
                ConfiguredRulesPunctuationAmpersandUsage.UseGermanWordUndExceptInCompanyNamesCommonAbbreviationsTitlesSoftwareCodeAndMathematicalEquations => "use_german_word_und_except_in_company_names_common_abbreviations_titles_software_code_and_mathematical_equations",
                ConfiguredRulesPunctuationAmpersandUsage.UseHalfWidthAmpersand => "use_half_width_ampersand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationAmpersandUsage? ToEnum(string value)
        {
            return value switch
            {
                "use_english_word_and_except_in_company_names_common_abbreviations_titles_software_code_and_mathematical_equations" => ConfiguredRulesPunctuationAmpersandUsage.UseEnglishWordAndExceptInCompanyNamesCommonAbbreviationsTitlesSoftwareCodeAndMathematicalEquations,
                "use_full_width_ampersand" => ConfiguredRulesPunctuationAmpersandUsage.UseFullWidthAmpersand,
                "use_german_word_und_except_in_company_names_common_abbreviations_titles_software_code_and_mathematical_equations" => ConfiguredRulesPunctuationAmpersandUsage.UseGermanWordUndExceptInCompanyNamesCommonAbbreviationsTitlesSoftwareCodeAndMathematicalEquations,
                "use_half_width_ampersand" => ConfiguredRulesPunctuationAmpersandUsage.UseHalfWidthAmpersand,
                _ => null,
            };
        }
    }
}