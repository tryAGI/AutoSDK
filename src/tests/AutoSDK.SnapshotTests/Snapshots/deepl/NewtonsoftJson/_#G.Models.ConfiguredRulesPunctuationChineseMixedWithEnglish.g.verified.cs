//HintName: G.Models.ConfiguredRulesPunctuationChineseMixedWithEnglish.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Chinese Mixed With English
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationChineseMixedWithEnglish
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_place_english_in_quotation_marks")]
        DoNotPlaceEnglishInQuotationMarks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="place_english_in_quotation_marks")]
        PlaceEnglishInQuotationMarks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationChineseMixedWithEnglishExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationChineseMixedWithEnglish value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationChineseMixedWithEnglish.DoNotPlaceEnglishInQuotationMarks => "do_not_place_english_in_quotation_marks",
                ConfiguredRulesPunctuationChineseMixedWithEnglish.PlaceEnglishInQuotationMarks => "place_english_in_quotation_marks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationChineseMixedWithEnglish? ToEnum(string value)
        {
            return value switch
            {
                "do_not_place_english_in_quotation_marks" => ConfiguredRulesPunctuationChineseMixedWithEnglish.DoNotPlaceEnglishInQuotationMarks,
                "place_english_in_quotation_marks" => ConfiguredRulesPunctuationChineseMixedWithEnglish.PlaceEnglishInQuotationMarks,
                _ => null,
            };
        }
    }
}