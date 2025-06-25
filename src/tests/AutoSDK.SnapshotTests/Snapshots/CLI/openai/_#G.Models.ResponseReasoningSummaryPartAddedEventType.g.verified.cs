//HintName: G.Models.ResponseReasoningSummaryPartAddedEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_summary_part.added`.
    /// </summary>
    public enum ResponseReasoningSummaryPartAddedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningSummaryPartAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningSummaryPartAddedEventType value)
        {
            return value switch
            {
                ResponseReasoningSummaryPartAddedEventType.ResponseReasoningSummaryPartAdded => "response.reasoning_summary_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningSummaryPartAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_part.added" => ResponseReasoningSummaryPartAddedEventType.ResponseReasoningSummaryPartAdded,
                _ => null,
            };
        }
    }
}