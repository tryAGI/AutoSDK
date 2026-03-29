//HintName: G.Models.ResponseOutputItemDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.output_item.done`.
    /// </summary>
    public enum ResponseOutputItemDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputItemDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemDoneEventType value)
        {
            return value switch
            {
                ResponseOutputItemDoneEventType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => ResponseOutputItemDoneEventType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}