//HintName: G.Models.InputAudioBufferClearedPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputAudioBufferClearedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.cleared")]
        InputAudioBufferCleared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioBufferClearedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferClearedPayloadType value)
        {
            return value switch
            {
                InputAudioBufferClearedPayloadType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferClearedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.cleared" => InputAudioBufferClearedPayloadType.InputAudioBufferCleared,
                _ => null,
            };
        }
    }
}