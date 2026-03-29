//HintName: G.Models.CallbackLiveAudioChunkAckMessageEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live.audio_chunk<br/>
    /// Example: live.audio_chunk
    /// </summary>
    public enum CallbackLiveAudioChunkAckMessageEvent
    {
        /// <summary>
        /// 
        /// </summary>
        LiveAudioChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLiveAudioChunkAckMessageEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLiveAudioChunkAckMessageEvent value)
        {
            return value switch
            {
                CallbackLiveAudioChunkAckMessageEvent.LiveAudioChunk => "live.audio_chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLiveAudioChunkAckMessageEvent? ToEnum(string value)
        {
            return value switch
            {
                "live.audio_chunk" => CallbackLiveAudioChunkAckMessageEvent.LiveAudioChunk,
                _ => null,
            };
        }
    }
}