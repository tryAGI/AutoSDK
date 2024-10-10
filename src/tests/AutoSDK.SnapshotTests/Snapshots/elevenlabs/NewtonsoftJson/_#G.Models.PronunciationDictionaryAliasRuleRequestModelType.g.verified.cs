//HintName: G.Models.PronunciationDictionaryAliasRuleRequestModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PronunciationDictionaryAliasRuleRequestModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alias")]
        Alias,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDictionaryAliasRuleRequestModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDictionaryAliasRuleRequestModelType value)
        {
            return value switch
            {
                PronunciationDictionaryAliasRuleRequestModelType.Alias => "alias",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDictionaryAliasRuleRequestModelType? ToEnum(string value)
        {
            return value switch
            {
                "alias" => PronunciationDictionaryAliasRuleRequestModelType.Alias,
                _ => null,
            };
        }
    }
}