//HintName: G.Models.ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Positive Vs Negative Language
    /// </summary>
    public enum ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        UsePositiveLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndTonePositiveVsNegativeLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage.UsePositiveLanguage => "use_positive_language",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage? ToEnum(string value)
        {
            return value switch
            {
                "use_positive_language" => ConfiguredRulesStyleAndTonePositiveVsNegativeLanguage.UsePositiveLanguage,
                _ => null,
            };
        }
    }
}