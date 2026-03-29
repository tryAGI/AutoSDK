//HintName: G.Models.ConfiguredRulesPunctuationUppercaseAcronyms.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Uppercase Acronyms
    /// </summary>
    public enum ConfiguredRulesPunctuationUppercaseAcronyms
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSpaces,
        /// <summary>
        /// 
        /// </summary>
        UseSpaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationUppercaseAcronymsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationUppercaseAcronyms value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationUppercaseAcronyms.DoNotUseSpaces => "do_not_use_spaces",
                ConfiguredRulesPunctuationUppercaseAcronyms.UseSpaces => "use_spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationUppercaseAcronyms? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_spaces" => ConfiguredRulesPunctuationUppercaseAcronyms.DoNotUseSpaces,
                "use_spaces" => ConfiguredRulesPunctuationUppercaseAcronyms.UseSpaces,
                _ => null,
            };
        }
    }
}