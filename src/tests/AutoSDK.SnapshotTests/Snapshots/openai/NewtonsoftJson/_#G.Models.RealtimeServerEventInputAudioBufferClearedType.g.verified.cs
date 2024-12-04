//HintName: G.Models.RealtimeServerEventInputAudioBufferClearedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.cleared`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventInputAudioBufferClearedType
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
    public static class RealtimeServerEventInputAudioBufferClearedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventInputAudioBufferClearedType value)
        {
            return value switch
            {
                RealtimeServerEventInputAudioBufferClearedType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventInputAudioBufferClearedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.cleared" => RealtimeServerEventInputAudioBufferClearedType.InputAudioBufferCleared,
                _ => null,
            };
        }
    }
}