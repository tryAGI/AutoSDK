//HintName: G.Models.TextNormalisationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Method for converting numbers to words before sending to TTS
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextNormalisationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system_prompt")]
        SystemPrompt,
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
                TextNormalisationType.Elevenlabs => "elevenlabs",
                TextNormalisationType.SystemPrompt => "system_prompt",
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
                "elevenlabs" => TextNormalisationType.Elevenlabs,
                "system_prompt" => TextNormalisationType.SystemPrompt,
                _ => null,
            };
        }
    }
}