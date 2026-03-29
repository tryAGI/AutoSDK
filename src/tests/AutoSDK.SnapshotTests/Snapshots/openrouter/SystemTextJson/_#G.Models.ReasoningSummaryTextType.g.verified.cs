//HintName: G.Models.ReasoningSummaryTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningSummaryTextType
    {
        /// <summary>
        /// 
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningSummaryTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummaryTextType value)
        {
            return value switch
            {
                ReasoningSummaryTextType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummaryTextType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => ReasoningSummaryTextType.SummaryText,
                _ => null,
            };
        }
    }
}