//HintName: G.Models.ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Space Between Chinese Characters And Arabic Numerals
    /// </summary>
    public enum ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumeralsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals value)
        {
            return value switch
            {
                ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals.DoNotUse => "do_not_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesFormattingSpaceBetweenChineseCharactersAndArabicNumerals.DoNotUse,
                _ => null,
            };
        }
    }
}