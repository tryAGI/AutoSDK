//HintName: G.Models.ResponseReasoningSummaryDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always 'response.reasoning_summary.delta'.
    /// </summary>
    public enum ResponseReasoningSummaryDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningSummaryDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningSummaryDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningSummaryDeltaEventType value)
        {
            return value switch
            {
                ResponseReasoningSummaryDeltaEventType.ResponseReasoningSummaryDelta => "response.reasoning_summary.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningSummaryDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary.delta" => ResponseReasoningSummaryDeltaEventType.ResponseReasoningSummaryDelta,
                _ => null,
            };
        }
    }
}