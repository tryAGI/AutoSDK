//HintName: G.Models.ConfiguredRulesPunctuationApostrophe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Apostrophe
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationApostrophe
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_curly_apostrophes")]
        UseCurlyApostrophes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_straight_apostrophes")]
        UseStraightApostrophes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationApostropheExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationApostrophe value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationApostrophe.UseCurlyApostrophes => "use_curly_apostrophes",
                ConfiguredRulesPunctuationApostrophe.UseStraightApostrophes => "use_straight_apostrophes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationApostrophe? ToEnum(string value)
        {
            return value switch
            {
                "use_curly_apostrophes" => ConfiguredRulesPunctuationApostrophe.UseCurlyApostrophes,
                "use_straight_apostrophes" => ConfiguredRulesPunctuationApostrophe.UseStraightApostrophes,
                _ => null,
            };
        }
    }
}