//HintName: G.Models.RealtimeClientEventInputAudioBufferClearType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.clear`.
    /// </summary>
    public enum RealtimeClientEventInputAudioBufferClearType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventInputAudioBufferClearTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventInputAudioBufferClearType value)
        {
            return value switch
            {
                RealtimeClientEventInputAudioBufferClearType.InputAudioBufferClear => "input_audio_buffer.clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventInputAudioBufferClearType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.clear" => RealtimeClientEventInputAudioBufferClearType.InputAudioBufferClear,
                _ => null,
            };
        }
    }
}