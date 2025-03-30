//HintName: G.Models.PronunciationDictionaryPhonemeRuleRequestModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the rule.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PronunciationDictionaryPhonemeRuleRequestModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoneme")]
        Phoneme,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictionaryPhonemeRuleRequestModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryPhonemeRuleRequestModelType value)
        {
            return value switch
            {
                PronunciationDictionaryPhonemeRuleRequestModelType.Phoneme => "phoneme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryPhonemeRuleRequestModelType? ToEnum(string value)
        {
            return value switch
            {
                "phoneme" => PronunciationDictionaryPhonemeRuleRequestModelType.Phoneme,
                _ => null,
            };
        }
    }
}