//HintName: G.Models.InputAudioBufferClearPayloadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type.
    /// </summary>
    public enum InputAudioBufferClearPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioBufferClearPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioBufferClearPayloadType value)
        {
            return value switch
            {
                InputAudioBufferClearPayloadType.InputAudioBufferClear => "input_audio_buffer.clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioBufferClearPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.clear" => InputAudioBufferClearPayloadType.InputAudioBufferClear,
                _ => null,
            };
        }
    }
}