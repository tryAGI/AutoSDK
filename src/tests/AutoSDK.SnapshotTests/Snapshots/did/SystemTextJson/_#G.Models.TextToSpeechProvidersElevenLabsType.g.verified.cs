//HintName: G.Models.TextToSpeechProvidersElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextToSpeechProvidersElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechProvidersElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechProvidersElevenLabsType value)
        {
            return value switch
            {
                TextToSpeechProvidersElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechProvidersElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => TextToSpeechProvidersElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}