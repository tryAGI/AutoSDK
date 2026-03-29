//HintName: G.Models.ConfiguredRulesStyleAndToneShortVsLongWords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Short Vs Long Words
    /// </summary>
    public enum ConfiguredRulesStyleAndToneShortVsLongWords
    {
        /// <summary>
        /// 
        /// </summary>
        UseShortWords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneShortVsLongWordsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneShortVsLongWords value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneShortVsLongWords.UseShortWords => "use_short_words",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneShortVsLongWords? ToEnum(string value)
        {
            return value switch
            {
                "use_short_words" => ConfiguredRulesStyleAndToneShortVsLongWords.UseShortWords,
                _ => null,
            };
        }
    }
}