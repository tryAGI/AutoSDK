//HintName: G.Models.TextNormalisationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Method for converting numbers to words before sending to TTS
    /// </summary>
    public enum TextNormalisationType
    {
        /// <summary>
        /// 
        /// </summary>
        SystemPrompt,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextNormalisationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextNormalisationType value)
        {
            return value switch
            {
                TextNormalisationType.SystemPrompt => "system_prompt",
                TextNormalisationType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextNormalisationType? ToEnum(string value)
        {
            return value switch
            {
                "system_prompt" => TextNormalisationType.SystemPrompt,
                "elevenlabs" => TextNormalisationType.Elevenlabs,
                _ => null,
            };
        }
    }
}