//HintName: G.Models.ConfiguredRulesStyleAndToneComplexSentences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Complex Sentences
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneComplexSentences
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="avoid_unnecessarily_complex_sentences")]
        AvoidUnnecessarilyComplexSentences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneComplexSentencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneComplexSentences value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneComplexSentences.AvoidUnnecessarilyComplexSentences => "avoid_unnecessarily_complex_sentences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneComplexSentences? ToEnum(string value)
        {
            return value switch
            {
                "avoid_unnecessarily_complex_sentences" => ConfiguredRulesStyleAndToneComplexSentences.AvoidUnnecessarilyComplexSentences,
                _ => null,
            };
        }
    }
}