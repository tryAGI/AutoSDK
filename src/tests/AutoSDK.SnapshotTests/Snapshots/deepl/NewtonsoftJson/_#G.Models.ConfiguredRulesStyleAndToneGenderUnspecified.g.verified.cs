//HintName: G.Models.ConfiguredRulesStyleAndToneGenderUnspecified.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Gender Unspecified
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneGenderUnspecified
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_both_masculine_and_feminine_forms")]
        UseBothMasculineAndFeminineForms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_gender_neutral_terms")]
        UseGenderNeutralTerms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_masculine_form_only")]
        UseMasculineFormOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_middle_dots")]
        UseMiddleDots,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_parentheses")]
        UseParentheses,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_periods")]
        UsePeriods,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneGenderUnspecifiedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneGenderUnspecified value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneGenderUnspecified.UseBothMasculineAndFeminineForms => "use_both_masculine_and_feminine_forms",
                ConfiguredRulesStyleAndToneGenderUnspecified.UseGenderNeutralTerms => "use_gender_neutral_terms",
                ConfiguredRulesStyleAndToneGenderUnspecified.UseMasculineFormOnly => "use_masculine_form_only",
                ConfiguredRulesStyleAndToneGenderUnspecified.UseMiddleDots => "use_middle_dots",
                ConfiguredRulesStyleAndToneGenderUnspecified.UseParentheses => "use_parentheses",
                ConfiguredRulesStyleAndToneGenderUnspecified.UsePeriods => "use_periods",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneGenderUnspecified? ToEnum(string value)
        {
            return value switch
            {
                "use_both_masculine_and_feminine_forms" => ConfiguredRulesStyleAndToneGenderUnspecified.UseBothMasculineAndFeminineForms,
                "use_gender_neutral_terms" => ConfiguredRulesStyleAndToneGenderUnspecified.UseGenderNeutralTerms,
                "use_masculine_form_only" => ConfiguredRulesStyleAndToneGenderUnspecified.UseMasculineFormOnly,
                "use_middle_dots" => ConfiguredRulesStyleAndToneGenderUnspecified.UseMiddleDots,
                "use_parentheses" => ConfiguredRulesStyleAndToneGenderUnspecified.UseParentheses,
                "use_periods" => ConfiguredRulesStyleAndToneGenderUnspecified.UsePeriods,
                _ => null,
            };
        }
    }
}