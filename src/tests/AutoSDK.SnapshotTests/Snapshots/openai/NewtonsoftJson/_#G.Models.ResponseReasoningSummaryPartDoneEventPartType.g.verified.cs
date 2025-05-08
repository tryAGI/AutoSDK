//HintName: G.Models.ResponseReasoningSummaryPartDoneEventPartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the summary part. Always `summary_text`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseReasoningSummaryPartDoneEventPartType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="summary_text")]
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