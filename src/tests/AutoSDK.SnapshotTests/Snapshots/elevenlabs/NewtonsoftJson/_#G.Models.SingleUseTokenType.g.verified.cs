//HintName: G.Models.SingleUseTokenType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SingleUseTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="realtime_scribe")]
        RealtimeScribe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tts_websocket")]
        TtsWebsocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SingleUseTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SingleUseTokenType value)
        {
            return value switch
            {
                SingleUseTokenType.RealtimeScribe => "realtime_scribe",
                SingleUseTokenType.TtsWebsocket => "tts_websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SingleUseTokenType? ToEnum(string value)
        {
            return value switch
            {
                "realtime_scribe" => SingleUseTokenType.RealtimeScribe,
                "tts_websocket" => SingleUseTokenType.TtsWebsocket,
                _ => null,
            };
        }
    }
}