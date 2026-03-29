//HintName: G.Models.PieInsightFromCallTableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `pie` to create a pie insight.
    /// </summary>
    public enum PieInsightFromCallTableType
    {
        /// <summary>
        /// 
        /// </summary>
        Pie,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PieInsightFromCallTableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PieInsightFromCallTableType value)
        {
            return value switch
            {
                PieInsightFromCallTableType.Pie => "pie",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PieInsightFromCallTableType? ToEnum(string value)
        {
            return value switch
            {
                "pie" => PieInsightFromCallTableType.Pie,
                _ => null,
            };
        }
    }
}