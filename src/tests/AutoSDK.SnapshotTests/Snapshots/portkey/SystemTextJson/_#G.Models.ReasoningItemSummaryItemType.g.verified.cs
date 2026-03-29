//HintName: G.Models.ReasoningItemSummaryItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object. Always `summary_text`.
    /// </summary>
    public enum ReasoningItemSummaryItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningItemSummaryItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningItemSummaryItemType value)
        {
            return value switch
            {
                ReasoningItemSummaryItemType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningItemSummaryItemType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => ReasoningItemSummaryItemType.SummaryText,
                _ => null,
            };
        }
    }
}