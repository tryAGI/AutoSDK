//HintName: G.Models.SpeechStartMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: speech_start<br/>
    /// Example: speech_start
    /// </summary>
    public enum SpeechStartMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechStartMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechStartMessageType value)
        {
            return value switch
            {
                SpeechStartMessageType.SpeechStart => "speech_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechStartMessageType? ToEnum(string value)
        {
            return value switch
            {
                "speech_start" => SpeechStartMessageType.SpeechStart,
                _ => null,
            };
        }
    }
}