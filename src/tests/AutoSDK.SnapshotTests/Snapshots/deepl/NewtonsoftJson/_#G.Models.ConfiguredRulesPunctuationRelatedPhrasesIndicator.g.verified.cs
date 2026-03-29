//HintName: G.Models.ConfiguredRulesPunctuationRelatedPhrasesIndicator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Related Phrases Indicator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationRelatedPhrasesIndicator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_comma")]
        UseComma,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_hyphen")]
        UseHyphen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_middle_dot")]
        UseMiddleDot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationRelatedPhrasesIndicatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationRelatedPhrasesIndicator value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationRelatedPhrasesIndicator.UseComma => "use_comma",
                ConfiguredRulesPunctuationRelatedPhrasesIndicator.UseHyphen => "use_hyphen",
                ConfiguredRulesPunctuationRelatedPhrasesIndicator.UseMiddleDot => "use_middle_dot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationRelatedPhrasesIndicator? ToEnum(string value)
        {
            return value switch
            {
                "use_comma" => ConfiguredRulesPunctuationRelatedPhrasesIndicator.UseComma,
                "use_hyphen" => ConfiguredRulesPunctuationRelatedPhrasesIndicator.UseHyphen,
                "use_middle_dot" => ConfiguredRulesPunctuationRelatedPhrasesIndicator.UseMiddleDot,
                _ => null,
            };
        }
    }
}