//HintName: G.Models.AgentRequestPronunciationDictionaryItemAlphabet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The phonetic alphabet to be used for pronunciation.<br/>
    /// Example: ipa
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentRequestPronunciationDictionaryItemAlphabet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cmu")]
        Cmu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ipa")]
        Ipa,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestPronunciationDictionaryItemAlphabetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestPronunciationDictionaryItemAlphabet value)
        {
            return value switch
            {
                AgentRequestPronunciationDictionaryItemAlphabet.Cmu => "cmu",
                AgentRequestPronunciationDictionaryItemAlphabet.Ipa => "ipa",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestPronunciationDictionaryItemAlphabet? ToEnum(string value)
        {
            return value switch
            {
                "cmu" => AgentRequestPronunciationDictionaryItemAlphabet.Cmu,
                "ipa" => AgentRequestPronunciationDictionaryItemAlphabet.Ipa,
                _ => null,
            };
        }
    }
}