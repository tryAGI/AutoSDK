//HintName: G.Models.AudioChunkActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: audio_chunk<br/>
    /// Example: audio_chunk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioChunkActionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_chunk")]
        AudioChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioChunkActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioChunkActionType value)
        {
            return value switch
            {
                AudioChunkActionType.AudioChunk => "audio_chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioChunkActionType? ToEnum(string value)
        {
            return value switch
            {
                "audio_chunk" => AudioChunkActionType.AudioChunk,
                _ => null,
            };
        }
    }
}