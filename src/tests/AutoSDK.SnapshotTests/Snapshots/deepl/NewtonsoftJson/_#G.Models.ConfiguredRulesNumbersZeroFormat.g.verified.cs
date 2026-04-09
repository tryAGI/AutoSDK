//HintName: G.Models.ConfiguredRulesNumbersZeroFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Zero Format
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesNumbersZeroFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_chinese_word_〇_for_numbering")]
        UseChineseWord_ForNumbering,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_chinese_word_零_for_measurement")]
        UseChineseWord零ForMeasurement,
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
                ConfiguredRulesNumbersZeroFormat.UseChineseWord零ForMeasurement => "use_chinese_word_零_for_measurement",
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
                "use_chinese_word_零_for_measurement" => ConfiguredRulesNumbersZeroFormat.UseChineseWord零ForMeasurement,
                _ => null,
            };
        }
    }
}