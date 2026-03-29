//HintName: G.Models.CreateStructuredOutputDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of structured output.<br/>
    /// - 'ai': Uses an LLM to extract structured data from the conversation (default).<br/>
    /// - 'regex': Uses a regex pattern to extract data from the transcript without an LLM.<br/>
    /// Defaults to 'ai' if not specified.<br/>
    /// Default Value: ai
    /// </summary>
    public enum CreateStructuredOutputDTOType
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
    public static class CreateStructuredOutputDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStructuredOutputDTOType value)
        {
            return value switch
            {
                CreateStructuredOutputDTOType.Ai => "ai",
                CreateStructuredOutputDTOType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStructuredOutputDTOType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => CreateStructuredOutputDTOType.Ai,
                "regex" => CreateStructuredOutputDTOType.Regex,
                _ => null,
            };
        }
    }
}