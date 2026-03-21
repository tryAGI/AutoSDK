//HintName: G.Models.AudioResponsePayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioResponsePayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioResponsePayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioResponsePayloadMessageType value)
        {
            return value switch
            {
                AudioResponsePayloadMessageType.AudioResponse => "audio_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioResponsePayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "audio_response" => AudioResponsePayloadMessageType.AudioResponse,
                _ => null,
            };
        }
    }
}