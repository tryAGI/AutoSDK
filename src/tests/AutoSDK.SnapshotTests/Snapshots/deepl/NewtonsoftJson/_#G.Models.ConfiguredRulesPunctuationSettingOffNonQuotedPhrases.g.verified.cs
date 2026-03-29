//HintName: G.Models.ConfiguredRulesPunctuationSettingOffNonQuotedPhrases.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Setting Off Non Quoted Phrases
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationSettingOffNonQuotedPhrases
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_full_width_quotation_marks")]
        UseFullWidthQuotationMarks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_half_width_quotation_marks")]
        UseHalfWidthQuotationMarks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationSettingOffNonQuotedPhrasesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationSettingOffNonQuotedPhrases value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationSettingOffNonQuotedPhrases.UseFullWidthQuotationMarks => "use_full_width_quotation_marks",
                ConfiguredRulesPunctuationSettingOffNonQuotedPhrases.UseHalfWidthQuotationMarks => "use_half_width_quotation_marks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationSettingOffNonQuotedPhrases? ToEnum(string value)
        {
            return value switch
            {
                "use_full_width_quotation_marks" => ConfiguredRulesPunctuationSettingOffNonQuotedPhrases.UseFullWidthQuotationMarks,
                "use_half_width_quotation_marks" => ConfiguredRulesPunctuationSettingOffNonQuotedPhrases.UseHalfWidthQuotationMarks,
                _ => null,
            };
        }
    }
}