//HintName: G.Models.InputAudioBufferAppendPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputAudioBufferAppendPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio_buffer.append")]
        InputAudioBufferAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioBufferAppendPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferAppendPayloadType value)
        {
            return value switch
            {
                InputAudioBufferAppendPayloadType.InputAudioBufferAppend => "input_audio_buffer.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferAppendPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.append" => InputAudioBufferAppendPayloadType.InputAudioBufferAppend,
                _ => null,
            };
        }
    }
}