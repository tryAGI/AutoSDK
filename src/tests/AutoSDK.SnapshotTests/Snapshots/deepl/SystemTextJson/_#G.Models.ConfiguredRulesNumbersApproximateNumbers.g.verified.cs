//HintName: G.Models.ConfiguredRulesNumbersApproximateNumbers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Approximate Numbers
    /// </summary>
    public enum ConfiguredRulesNumbersApproximateNumbers
    {
        /// <summary>
        /// 
        /// </summary>
        UseKanjiNumbers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersApproximateNumbersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersApproximateNumbers value)
        {
            return value switch
            {
                ConfiguredRulesNumbersApproximateNumbers.UseKanjiNumbers => "use_kanji_numbers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersApproximateNumbers? ToEnum(string value)
        {
            return value switch
            {
                "use_kanji_numbers" => ConfiguredRulesNumbersApproximateNumbers.UseKanjiNumbers,
                _ => null,
            };
        }
    }
}