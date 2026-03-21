//HintName: G.Models.AudioDataPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioDataPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioData,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioDataPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioDataPayloadMessageType value)
        {
            return value switch
            {
                AudioDataPayloadMessageType.AudioData => "audio_data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioDataPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "audio_data" => AudioDataPayloadMessageType.AudioData,
                _ => null,
            };
        }
    }
}