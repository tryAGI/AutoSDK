//HintName: G.Models.ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Space Between Arabic Numerals And Unit
    /// </summary>
    public enum ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit value)
        {
            return value switch
            {
                ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit.DoNotUse => "do_not_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesFormattingSpaceBetweenArabicNumeralsAndUnit.DoNotUse,
                _ => null,
            };
        }
    }
}