//HintName: G.Models.RealtimeServerEventResponseOutputItemAddedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The event type, must be `response.output_item.added`.
    /// </summary>
    public enum RealtimeServerEventResponseOutputItemAddedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseOutputItemAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseOutputItemAddedType value)
        {
            return value switch
            {
                RealtimeServerEventResponseOutputItemAddedType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseOutputItemAddedType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => RealtimeServerEventResponseOutputItemAddedType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}