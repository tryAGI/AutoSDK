//HintName: G.Models.InputAudioBufferCommittedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputAudioBufferCommittedEventType
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
    public static class InputAudioBufferCommittedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferCommittedEventType value)
        {
            return value switch
            {
                InputAudioBufferCommittedEventType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferCommittedEventType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.committed" => InputAudioBufferCommittedEventType.InputAudioBufferCommitted,
                _ => null,
            };
        }
    }
}