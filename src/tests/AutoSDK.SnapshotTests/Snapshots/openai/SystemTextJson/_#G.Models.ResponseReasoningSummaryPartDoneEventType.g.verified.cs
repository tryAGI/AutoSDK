//HintName: G.Models.ResponseReasoningSummaryPartDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_summary_part.done`.
    /// </summary>
    public enum ResponseReasoningSummaryPartDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningSummaryPartDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningSummaryPartDoneEventType value)
        {
            return value switch
            {
                ResponseReasoningSummaryPartDoneEventType.ResponseReasoningSummaryPartDone => "response.reasoning_summary_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningSummaryPartDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_part.done" => ResponseReasoningSummaryPartDoneEventType.ResponseReasoningSummaryPartDone,
                _ => null,
            };
        }
    }
}