//HintName: G.Models.RealtimeServerEventOutputAudioBufferStartedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `output_audio_buffer.started`.
    /// </summary>
    public enum RealtimeServerEventOutputAudioBufferStartedType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventOutputAudioBufferStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventOutputAudioBufferStartedType value)
        {
            return value switch
            {
                RealtimeServerEventOutputAudioBufferStartedType.OutputAudioBufferStarted => "output_audio_buffer.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventOutputAudioBufferStartedType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.started" => RealtimeServerEventOutputAudioBufferStartedType.OutputAudioBufferStarted,
                _ => null,
            };
        }
    }
}