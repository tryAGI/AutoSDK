//HintName: G.Models.LineInsightFromCallTableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `line` to create a line insight.
    /// </summary>
    public enum LineInsightFromCallTableType
    {
        /// <summary>
        /// 
        /// </summary>
        Line,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LineInsightFromCallTableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LineInsightFromCallTableType value)
        {
            return value switch
            {
                LineInsightFromCallTableType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LineInsightFromCallTableType? ToEnum(string value)
        {
            return value switch
            {
                "line" => LineInsightFromCallTableType.Line,
                _ => null,
            };
        }
    }
}