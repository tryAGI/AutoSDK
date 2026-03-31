//HintName: G.Models.PromptParserNullishType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptParserNullishType
    {
        /// <summary>
        /// 
        /// </summary>
        LlmClassifier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptParserNullishTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptParserNullishType value)
        {
            return value switch
            {
                PromptParserNullishType.LlmClassifier => "llm_classifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptParserNullishType? ToEnum(string value)
        {
            return value switch
            {
                "llm_classifier" => PromptParserNullishType.LlmClassifier,
                _ => null,
            };
        }
    }
}