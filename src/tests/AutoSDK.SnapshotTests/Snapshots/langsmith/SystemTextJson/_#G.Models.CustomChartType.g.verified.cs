//HintName: G.Models.CustomChartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for custom chart types.
    /// </summary>
    public enum CustomChartType
    {
        /// <summary>
        /// 
        /// </summary>
        Bar,
        /// <summary>
        /// 
        /// </summary>
        Line,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartType value)
        {
            return value switch
            {
                CustomChartType.Bar => "bar",
                CustomChartType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => CustomChartType.Bar,
                "line" => CustomChartType.Line,
                _ => null,
            };
        }
    }
}