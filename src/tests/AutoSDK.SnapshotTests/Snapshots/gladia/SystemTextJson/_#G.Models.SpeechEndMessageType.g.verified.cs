//HintName: G.Models.SpeechEndMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: speech_end<br/>
    /// Example: speech_end
    /// </summary>
    public enum SpeechEndMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechEnd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechEndMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechEndMessageType value)
        {
            return value switch
            {
                SpeechEndMessageType.SpeechEnd => "speech_end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechEndMessageType? ToEnum(string value)
        {
            return value switch
            {
                "speech_end" => SpeechEndMessageType.SpeechEnd,
                _ => null,
            };
        }
    }
}