﻿//HintName: G.Models.RealtimeServerEventResponseAudioDeltaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.audio.delta`.
    /// </summary>
    public enum RealtimeServerEventResponseAudioDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseAudioDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseAudioDeltaType value)
        {
            return value switch
            {
                RealtimeServerEventResponseAudioDeltaType.ResponseAudioDelta => "response.audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseAudioDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.delta" => RealtimeServerEventResponseAudioDeltaType.ResponseAudioDelta,
                _ => null,
            };
        }
    }
}