//HintName: G.Models.ResponseReasoningSummaryTextDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_summary_text.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseReasoningSummaryTextDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response.reasoning_summary_text.delta")]
        ResponseReasoningSummaryTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningSummaryTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningSummaryTextDeltaEventType value)
        {
            return value switch
            {
                ResponseReasoningSummaryTextDeltaEventType.ResponseReasoningSummaryTextDelta => "response.reasoning_summary_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningSummaryTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_text.delta" => ResponseReasoningSummaryTextDeltaEventType.ResponseReasoningSummaryTextDelta,
                _ => null,
            };
        }
    }
}