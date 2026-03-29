//HintName: G.Models.ReasoningDetailSummaryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningDetailSummaryType
    {
        /// <summary>
        /// 
        /// </summary>
        ReasoningSummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailSummaryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailSummaryType value)
        {
            return value switch
            {
                ReasoningDetailSummaryType.ReasoningSummary => "reasoning.summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailSummaryType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.summary" => ReasoningDetailSummaryType.ReasoningSummary,
                _ => null,
            };
        }
    }
}