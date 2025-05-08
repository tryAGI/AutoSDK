//HintName: G.Models.RealtimeClientEventOutputAudioBufferClearType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `output_audio_buffer.clear`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeClientEventOutputAudioBufferClearType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_audio_buffer.clear")]
        OutputAudioBufferClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeClientEventOutputAudioBufferClearTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeClientEventOutputAudioBufferClearType value)
        {
            return value switch
            {
                RealtimeClientEventOutputAudioBufferClearType.OutputAudioBufferClear => "output_audio_buffer.clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeClientEventOutputAudioBufferClearType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.clear" => RealtimeClientEventOutputAudioBufferClearType.OutputAudioBufferClear,
                _ => null,
            };
        }
    }
}