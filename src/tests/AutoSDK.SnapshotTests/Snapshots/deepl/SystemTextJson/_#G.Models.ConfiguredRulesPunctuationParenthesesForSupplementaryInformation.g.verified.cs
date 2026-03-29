//HintName: G.Models.ConfiguredRulesPunctuationParenthesesForSupplementaryInformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Parentheses For Supplementary Information
    /// </summary>
    public enum ConfiguredRulesPunctuationParenthesesForSupplementaryInformation
    {
        /// <summary>
        /// 
        /// </summary>
        UseParenthesesWithoutSpaceOnEitherSide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationParenthesesForSupplementaryInformationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationParenthesesForSupplementaryInformation value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationParenthesesForSupplementaryInformation.UseParenthesesWithoutSpaceOnEitherSide => "use_parentheses_without_space_on_either_side",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationParenthesesForSupplementaryInformation? ToEnum(string value)
        {
            return value switch
            {
                "use_parentheses_without_space_on_either_side" => ConfiguredRulesPunctuationParenthesesForSupplementaryInformation.UseParenthesesWithoutSpaceOnEitherSide,
                _ => null,
            };
        }
    }
}