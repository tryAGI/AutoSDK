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
        AudioEvent,
        /// <summary>
        /// 
        /// </summary>
        Spacing,
        /// <summary>
        /// 
        /// </summary>
        Word,
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
                SpeechToTextWordResponseModelType.AudioEvent => "audio_event",
                SpeechToTextWordResponseModelType.Spacing => "spacing",
                SpeechToTextWordResponseModelType.Word => "word",
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
                "audio_event" => SpeechToTextWordResponseModelType.AudioEvent,
                "spacing" => SpeechToTextWordResponseModelType.Spacing,
                "word" => SpeechToTextWordResponseModelType.Word,
                _ => null,
            };
        }
    }
}