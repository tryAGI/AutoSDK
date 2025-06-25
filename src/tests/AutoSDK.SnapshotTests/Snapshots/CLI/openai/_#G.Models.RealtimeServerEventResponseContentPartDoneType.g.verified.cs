//HintName: G.Models.RealtimeServerEventResponseContentPartDoneType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.content_part.done`.
    /// </summary>
    public enum RealtimeServerEventResponseContentPartDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseContentPartDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseContentPartDoneType value)
        {
            return value switch
            {
                RealtimeServerEventResponseContentPartDoneType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseContentPartDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => RealtimeServerEventResponseContentPartDoneType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}