//HintName: G.Models.LanguageModelConfigGranularity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LanguageModelConfigGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        Passage,
        /// <summary>
        /// 
        /// </summary>
        Sentence,
        /// <summary>
        /// 
        /// </summary>
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