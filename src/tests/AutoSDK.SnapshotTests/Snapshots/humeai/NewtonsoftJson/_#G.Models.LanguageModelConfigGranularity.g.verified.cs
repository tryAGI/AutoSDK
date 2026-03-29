//HintName: G.Models.LanguageModelConfigGranularity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LanguageModelConfigGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="passage")]
        Passage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sentence")]
        Sentence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageModelConfigGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LanguageModelConfigGranularity value)
        {
            return value switch
            {
                LanguageModelConfigGranularity.Passage => "passage",
                LanguageModelConfigGranularity.Sentence => "sentence",
                LanguageModelConfigGranularity.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LanguageModelConfigGranularity? ToEnum(string value)
        {
            return value switch
            {
                "passage" => LanguageModelConfigGranularity.Passage,
                "sentence" => LanguageModelConfigGranularity.Sentence,
                "word" => LanguageModelConfigGranularity.Word,
                _ => null,
            };
        }
    }
}