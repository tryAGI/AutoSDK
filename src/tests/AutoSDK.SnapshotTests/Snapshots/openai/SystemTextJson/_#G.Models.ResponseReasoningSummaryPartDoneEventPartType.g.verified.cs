//HintName: G.Models.ResponseReasoningSummaryPartDoneEventPartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the summary part. Always `summary_text`.
    /// </summary>
    public enum ResponseReasoningSummaryPartDoneEventPartType
    {
        /// <summary>
        /// 
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningSummaryPartDoneEventPartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningSummaryPartDoneEventPartType value)
        {
            return value switch
            {
                ResponseReasoningSummaryPartDoneEventPartType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningSummaryPartDoneEventPartType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => ResponseReasoningSummaryPartDoneEventPartType.SummaryText,
                _ => null,
            };
        }
    }
}