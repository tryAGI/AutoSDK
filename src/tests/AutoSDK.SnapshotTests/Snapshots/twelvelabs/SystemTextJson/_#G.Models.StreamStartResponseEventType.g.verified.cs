//HintName: G.Models.StreamStartResponseEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This field is always set to `stream_start` for this event.
    /// </summary>
    public enum StreamStartResponseEventType
    {
        /// <summary>
        /// 
        /// </summary>
        StreamStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamStartResponseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamStartResponseEventType value)
        {
            return value switch
            {
                StreamStartResponseEventType.StreamStart => "stream_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamStartResponseEventType? ToEnum(string value)
        {
            return value switch
            {
                "stream_start" => StreamStartResponseEventType.StreamStart,
                _ => null,
            };
        }
    }
}