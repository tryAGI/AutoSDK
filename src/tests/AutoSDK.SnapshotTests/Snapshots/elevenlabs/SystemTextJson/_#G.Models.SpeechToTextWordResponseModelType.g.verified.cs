//HintName: G.Models.SpeechToTextWordResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the word or sound. 'audio_event' is used for non-word sounds like laughter or footsteps.
    /// </summary>
    public enum SpeechToTextWordResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Word,
        /// <summary>
        /// 
        /// </summary>
        Spacing,
        /// <summary>
        /// 
        /// </summary>
        AudioEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechToTextWordResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechToTextWordResponseModelType value)
        {
            return value switch
            {
                SpeechToTextWordResponseModelType.Word => "word",
                SpeechToTextWordResponseModelType.Spacing => "spacing",
                SpeechToTextWordResponseModelType.AudioEvent => "audio_event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechToTextWordResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "word" => SpeechToTextWordResponseModelType.Word,
                "spacing" => SpeechToTextWordResponseModelType.Spacing,
                "audio_event" => SpeechToTextWordResponseModelType.AudioEvent,
                _ => null,
            };
        }
    }
}