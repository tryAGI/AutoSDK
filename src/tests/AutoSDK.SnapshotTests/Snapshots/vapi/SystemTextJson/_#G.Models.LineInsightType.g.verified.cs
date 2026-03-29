//HintName: G.Models.LineInsightType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `line` to create a line insight.
    /// </summary>
    public enum LineInsightType
    {
        /// <summary>
        /// 
        /// </summary>
        Line,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LineInsightTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LineInsightType value)
        {
            return value switch
            {
                LineInsightType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LineInsightType? ToEnum(string value)
        {
            return value switch
            {
                "line" => LineInsightType.Line,
                _ => null,
            };
        }
    }
}