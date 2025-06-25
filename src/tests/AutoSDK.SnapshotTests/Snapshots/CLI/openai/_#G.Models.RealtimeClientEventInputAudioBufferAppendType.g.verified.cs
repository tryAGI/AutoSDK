//HintName: G.Models.RealtimeClientEventInputAudioBufferAppendType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.append`.
    /// </summary>
    public enum RealtimeClientEventInputAudioBufferAppendType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventInputAudioBufferAppendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventInputAudioBufferAppendType value)
        {
            return value switch
            {
                RealtimeClientEventInputAudioBufferAppendType.InputAudioBufferAppend => "input_audio_buffer.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventInputAudioBufferAppendType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.append" => RealtimeClientEventInputAudioBufferAppendType.InputAudioBufferAppend,
                _ => null,
            };
        }
    }
}