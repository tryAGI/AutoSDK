//HintName: G.Models.ConfiguredRulesPunctuationSlashUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Slash Usage
    /// </summary>
    public enum ConfiguredRulesPunctuationSlashUsage
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSlashToSymbolizeEnglishWordOr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationSlashUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationSlashUsage value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationSlashUsage.DoNotUseSlashToSymbolizeEnglishWordOr => "do_not_use_slash_to_symbolize_english_word_or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationSlashUsage? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_slash_to_symbolize_english_word_or" => ConfiguredRulesPunctuationSlashUsage.DoNotUseSlashToSymbolizeEnglishWordOr,
                _ => null,
            };
        }
    }
}