//HintName: G.Models.ResponseReasoningSummaryTextDoneEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_summary_text.done`.
    /// </summary>
    public enum ResponseReasoningSummaryTextDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningSummaryTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningSummaryTextDoneEventType value)
        {
            return value switch
            {
                ResponseReasoningSummaryTextDoneEventType.ResponseReasoningSummaryTextDone => "response.reasoning_summary_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningSummaryTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_text.done" => ResponseReasoningSummaryTextDoneEventType.ResponseReasoningSummaryTextDone,
                _ => null,
            };
        }
    }
}