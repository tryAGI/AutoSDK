//HintName: G.Models.ResponseOutputItemAddedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.output_item.added`.
    /// </summary>
    public enum ResponseOutputItemAddedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOutputItemAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOutputItemAddedEventType value)
        {
            return value switch
            {
                ResponseOutputItemAddedEventType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOutputItemAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => ResponseOutputItemAddedEventType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}