//HintName: G.Models.InputAudioBufferCommittedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum InputAudioBufferCommittedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioBufferCommittedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferCommittedPayloadType value)
        {
            return value switch
            {
                InputAudioBufferCommittedPayloadType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferCommittedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.committed" => InputAudioBufferCommittedPayloadType.InputAudioBufferCommitted,
                _ => null,
            };
        }
    }
}