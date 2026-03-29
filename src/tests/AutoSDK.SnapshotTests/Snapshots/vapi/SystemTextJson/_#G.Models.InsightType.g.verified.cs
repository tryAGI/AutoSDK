//HintName: G.Models.InsightType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.
    /// </summary>
    public enum InsightType
    {
        /// <summary>
        /// 
        /// </summary>
        Bar,
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        Pie,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InsightTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightType value)
        {
            return value switch
            {
                InsightType.Bar => "bar",
                InsightType.Line => "line",
                InsightType.Pie => "pie",
                InsightType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => InsightType.Bar,
                "line" => InsightType.Line,
                "pie" => InsightType.Pie,
                "text" => InsightType.Text,
                _ => null,
            };
        }
    }
}