//HintName: G.Models.ResponseReasoningSummaryDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.reasoning_summary.done'.
    /// </summary>
    public enum ResponseReasoningSummaryDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningSummaryDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningSummaryDoneEventType value)
        {
            return value switch
            {
                ResponseReasoningSummaryDoneEventType.ResponseReasoningSummaryDone => "response.reasoning_summary.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningSummaryDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary.done" => ResponseReasoningSummaryDoneEventType.ResponseReasoningSummaryDone,
                _ => null,
            };
        }
    }
}