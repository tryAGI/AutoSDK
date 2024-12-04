//HintName: G.Models.RealtimeServerEventInputAudioBufferCommittedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.committed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventInputAudioBufferCommittedType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.committed")]
        InputAudioBufferCommitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventInputAudioBufferCommittedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventInputAudioBufferCommittedType value)
        {
            return value switch
            {
                RealtimeServerEventInputAudioBufferCommittedType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventInputAudioBufferCommittedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.committed" => RealtimeServerEventInputAudioBufferCommittedType.InputAudioBufferCommitted,
                _ => null,
            };
        }
    }
}