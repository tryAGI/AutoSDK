//HintName: G.Models.ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Space Between Chinese And English
    /// </summary>
    public enum ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesFormattingSpaceBetweenChineseAndEnglishExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish value)
        {
            return value switch
            {
                ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish.DoNotUse => "do_not_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesFormattingSpaceBetweenChineseAndEnglish.DoNotUse,
                _ => null,
            };
        }
    }
}