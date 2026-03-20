//HintName: G.Models.InputAudioBufferCommitPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputAudioBufferCommitPayloadType
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
    public static class InputAudioBufferCommitPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferCommitPayloadType value)
        {
            return value switch
            {
                InputAudioBufferCommitPayloadType.InputAudioBufferCommit => "input_audio_buffer.commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferCommitPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.commit" => InputAudioBufferCommitPayloadType.InputAudioBufferCommit,
                _ => null,
            };
        }
    }
}