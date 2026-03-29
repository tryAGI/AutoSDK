//HintName: G.Models.ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Titles Of Creative Works Trade Names Laws And Regulations
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_single_angle_brackets")]
        UseSingleAngleBrackets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_single_corner_brackets")]
        UseSingleCornerBrackets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_single_straight_quotation_marks")]
        UseSingleStraightQuotationMarks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations.UseSingleAngleBrackets => "use_single_angle_brackets",
                ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations.UseSingleCornerBrackets => "use_single_corner_brackets",
                ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations.UseSingleStraightQuotationMarks => "use_single_straight_quotation_marks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations? ToEnum(string value)
        {
            return value switch
            {
                "use_single_angle_brackets" => ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations.UseSingleAngleBrackets,
                "use_single_corner_brackets" => ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations.UseSingleCornerBrackets,
                "use_single_straight_quotation_marks" => ConfiguredRulesPunctuationTitlesOfCreativeWorksTradeNamesLawsAndRegulations.UseSingleStraightQuotationMarks,
                _ => null,
            };
        }
    }
}