//HintName: G.Models.ConfiguredRulesPunctuationExplanatoryNoteIndicator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Explanatory Note Indicator
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationExplanatoryNoteIndicator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_double_em_dash")]
        UseDoubleEmDash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_parentheses")]
        UseParentheses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationExplanatoryNoteIndicatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationExplanatoryNoteIndicator value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationExplanatoryNoteIndicator.UseDoubleEmDash => "use_double_em_dash",
                ConfiguredRulesPunctuationExplanatoryNoteIndicator.UseParentheses => "use_parentheses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationExplanatoryNoteIndicator? ToEnum(string value)
        {
            return value switch
            {
                "use_double_em_dash" => ConfiguredRulesPunctuationExplanatoryNoteIndicator.UseDoubleEmDash,
                "use_parentheses" => ConfiguredRulesPunctuationExplanatoryNoteIndicator.UseParentheses,
                _ => null,
            };
        }
    }
}