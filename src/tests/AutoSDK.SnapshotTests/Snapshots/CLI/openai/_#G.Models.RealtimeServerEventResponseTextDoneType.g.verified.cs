//HintName: G.Models.RealtimeServerEventResponseTextDoneType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.text.done`.
    /// </summary>
    public enum RealtimeServerEventResponseTextDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseTextDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseTextDoneType value)
        {
            return value switch
            {
                RealtimeServerEventResponseTextDoneType.ResponseTextDone => "response.text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseTextDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.text.done" => RealtimeServerEventResponseTextDoneType.ResponseTextDone,
                _ => null,
            };
        }
    }
}