//HintName: G.Models.RealtimeClientEventInputAudioBufferCommitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.commit`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeClientEventInputAudioBufferCommitType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.commit")]
        InputAudioBufferCommit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventInputAudioBufferCommitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventInputAudioBufferCommitType value)
        {
            return value switch
            {
                RealtimeClientEventInputAudioBufferCommitType.InputAudioBufferCommit => "input_audio_buffer.commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventInputAudioBufferCommitType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.commit" => RealtimeClientEventInputAudioBufferCommitType.InputAudioBufferCommit,
                _ => null,
            };
        }
    }
}