//HintName: G.Models.ReasoningItemContentItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object. Always `text`.
    /// </summary>
    public enum ReasoningItemContentItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ReasoningSummary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningItemContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningItemContentItemType value)
        {
            return value switch
            {
                ReasoningItemContentItemType.ReasoningSummary => "reasoning_summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningItemContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning_summary" => ReasoningItemContentItemType.ReasoningSummary,
                _ => null,
            };
        }
    }
}