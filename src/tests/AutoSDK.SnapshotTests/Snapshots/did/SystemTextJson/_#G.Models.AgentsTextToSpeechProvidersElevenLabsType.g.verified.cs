//HintName: G.Models.AgentsTextToSpeechProvidersElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsTextToSpeechProvidersElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsTextToSpeechProvidersElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsTextToSpeechProvidersElevenLabsType value)
        {
            return value switch
            {
                AgentsTextToSpeechProvidersElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsTextToSpeechProvidersElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => AgentsTextToSpeechProvidersElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}