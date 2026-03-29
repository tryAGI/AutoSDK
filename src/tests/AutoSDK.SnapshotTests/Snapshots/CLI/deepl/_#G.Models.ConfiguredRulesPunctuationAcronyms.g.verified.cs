//HintName: G.Models.ConfiguredRulesPunctuationAcronyms.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Acronyms
    /// </summary>
    public enum ConfiguredRulesPunctuationAcronyms
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUsePeriods,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationAcronymsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationAcronyms value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationAcronyms.DoNotUsePeriods => "do_not_use_periods",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationAcronyms? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_periods" => ConfiguredRulesPunctuationAcronyms.DoNotUsePeriods,
                _ => null,
            };
        }
    }
}