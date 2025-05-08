//HintName: G.Models.RealtimeServerEventOutputAudioBufferClearedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `output_audio_buffer.cleared`.
    /// </summary>
    public enum RealtimeServerEventOutputAudioBufferClearedType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferCleared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventOutputAudioBufferClearedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventOutputAudioBufferClearedType value)
        {
            return value switch
            {
                RealtimeServerEventOutputAudioBufferClearedType.OutputAudioBufferCleared => "output_audio_buffer.cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventOutputAudioBufferClearedType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.cleared" => RealtimeServerEventOutputAudioBufferClearedType.OutputAudioBufferCleared,
                _ => null,
            };
        }
    }
}