//HintName: G.Models.InputAudioChunkPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'input_audio_chunk'.
    /// </summary>
    public enum InputAudioChunkPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioChunkPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioChunkPayloadMessageType value)
        {
            return value switch
            {
                InputAudioChunkPayloadMessageType.InputAudioChunk => "input_audio_chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioChunkPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_chunk" => InputAudioChunkPayloadMessageType.InputAudioChunk,
                _ => null,
            };
        }
    }
}