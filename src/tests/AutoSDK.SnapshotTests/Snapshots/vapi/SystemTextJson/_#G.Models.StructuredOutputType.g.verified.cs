//HintName: G.Models.StructuredOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of structured output.<br/>
    /// - 'ai': Uses an LLM to extract structured data from the conversation (default).<br/>
    /// - 'regex': Uses a regex pattern to extract data from the transcript without an LLM.
    /// </summary>
    public enum StructuredOutputType
    {
        /// <summary>
        /// Uses an LLM to extract structured data from the conversation (default).
        /// </summary>
        Ai,
        /// <summary>
        /// Uses a regex pattern to extract data from the transcript without an LLM.
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredOutputType value)
        {
            return value switch
            {
                StructuredOutputType.Ai => "ai",
                StructuredOutputType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredOutputType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => StructuredOutputType.Ai,
                "regex" => StructuredOutputType.Regex,
                _ => null,
            };
        }
    }
}