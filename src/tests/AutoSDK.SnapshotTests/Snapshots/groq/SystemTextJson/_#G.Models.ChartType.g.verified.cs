//HintName: G.Models.ChartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of chart
    /// </summary>
    public enum ChartType
    {
        /// <summary>
        /// 
        /// </summary>
        Bar,
        /// <summary>
        /// 
        /// </summary>
        BoxAndWhisker,
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
        Scatter,
        /// <summary>
        /// 
        /// </summary>
        Superchart,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChartType value)
        {
            return value switch
            {
                ChartType.Bar => "bar",
                ChartType.BoxAndWhisker => "box_and_whisker",
                ChartType.Line => "line",
                ChartType.Pie => "pie",
                ChartType.Scatter => "scatter",
                ChartType.Superchart => "superchart",
                ChartType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => ChartType.Bar,
                "box_and_whisker" => ChartType.BoxAndWhisker,
                "line" => ChartType.Line,
                "pie" => ChartType.Pie,
                "scatter" => ChartType.Scatter,
                "superchart" => ChartType.Superchart,
                "unknown" => ChartType.Unknown,
                _ => null,
            };
        }
    }
}