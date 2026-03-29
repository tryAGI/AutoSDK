//HintName: G.Models.ElevenLabsTextToSpeechOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-to-speech` for text-to-speech.
    /// </summary>
    public enum ElevenLabsTextToSpeechOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsTextToSpeechOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsTextToSpeechOptionsType value)
        {
            return value switch
            {
                ElevenLabsTextToSpeechOptionsType.TextToSpeech => "text-to-speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsTextToSpeechOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-speech" => ElevenLabsTextToSpeechOptionsType.TextToSpeech,
                _ => null,
            };
        }
    }
}