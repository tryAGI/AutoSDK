//HintName: G.Models.RealtimeServerEventResponseOutputItemDoneType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.output_item.done`.
    /// </summary>
    public enum RealtimeServerEventResponseOutputItemDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseOutputItemDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseOutputItemDoneType value)
        {
            return value switch
            {
                RealtimeServerEventResponseOutputItemDoneType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseOutputItemDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => RealtimeServerEventResponseOutputItemDoneType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}