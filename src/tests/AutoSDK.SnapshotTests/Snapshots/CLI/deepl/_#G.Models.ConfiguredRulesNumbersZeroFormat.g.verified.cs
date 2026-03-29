//HintName: G.Models.ConfiguredRulesNumbersZeroFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Zero Format
    /// </summary>
    public enum ConfiguredRulesNumbersZeroFormat
    {
        /// <summary>
        /// 
        /// </summary>
        UseChineseWord_ForNumbering,
        /// <summary>
        /// 
        /// </summary>
        UseChineseWord_ForMeasurement,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersZeroFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersZeroFormat value)
        {
            return value switch
            {
                ConfiguredRulesNumbersZeroFormat.UseChineseWord_ForNumbering => "use_chinese_word_〇_for_numbering",
                ConfiguredRulesNumbersZeroFormat.UseChineseWord_ForMeasurement => "use_chinese_word_零_for_measurement",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersZeroFormat? ToEnum(string value)
        {
            return value switch
            {
                "use_chinese_word_〇_for_numbering" => ConfiguredRulesNumbersZeroFormat.UseChineseWord_ForNumbering,
                "use_chinese_word_零_for_measurement" => ConfiguredRulesNumbersZeroFormat.UseChineseWord_ForMeasurement,
                _ => null,
            };
        }
    }
}