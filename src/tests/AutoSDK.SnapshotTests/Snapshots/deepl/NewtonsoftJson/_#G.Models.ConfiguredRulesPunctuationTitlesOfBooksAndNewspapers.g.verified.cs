//HintName: G.Models.ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Titles Of Books And Newspapers
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_angle_brackets")]
        UseDoubleAngleBrackets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_corner_brackets")]
        UseDoubleCornerBrackets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_straight_quotation_marks")]
        UseDoubleStraightQuotationMarks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationTitlesOfBooksAndNewspapersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers.UseDoubleAngleBrackets => "use_double_angle_brackets",
                ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers.UseDoubleCornerBrackets => "use_double_corner_brackets",
                ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers.UseDoubleStraightQuotationMarks => "use_double_straight_quotation_marks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers? ToEnum(string value)
        {
            return value switch
            {
                "use_double_angle_brackets" => ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers.UseDoubleAngleBrackets,
                "use_double_corner_brackets" => ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers.UseDoubleCornerBrackets,
                "use_double_straight_quotation_marks" => ConfiguredRulesPunctuationTitlesOfBooksAndNewspapers.UseDoubleStraightQuotationMarks,
                _ => null,
            };
        }
    }
}