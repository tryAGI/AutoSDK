//HintName: G.Models.RealtimeServerEventOutputAudioBufferStoppedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `output_audio_buffer.stopped`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventOutputAudioBufferStoppedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_audio_buffer.stopped")]
        OutputAudioBufferStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventOutputAudioBufferStoppedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventOutputAudioBufferStoppedType value)
        {
            return value switch
            {
                RealtimeServerEventOutputAudioBufferStoppedType.OutputAudioBufferStopped => "output_audio_buffer.stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventOutputAudioBufferStoppedType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.stopped" => RealtimeServerEventOutputAudioBufferStoppedType.OutputAudioBufferStopped,
                _ => null,
            };
        }
    }
}