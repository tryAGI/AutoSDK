//HintName: G.Models.ConfiguredRulesPunctuationEmphasis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Emphasis
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationEmphasis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_corner_brackets")]
        UseDoubleCornerBrackets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationEmphasisExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationEmphasis value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationEmphasis.UseDoubleCornerBrackets => "use_double_corner_brackets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationEmphasis? ToEnum(string value)
        {
            return value switch
            {
                "use_double_corner_brackets" => ConfiguredRulesPunctuationEmphasis.UseDoubleCornerBrackets,
                _ => null,
            };
        }
    }
}