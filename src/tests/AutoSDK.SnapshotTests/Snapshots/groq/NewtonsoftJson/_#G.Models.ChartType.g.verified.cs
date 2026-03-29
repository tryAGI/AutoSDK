//HintName: G.Models.ChartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of chart
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChartType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bar")]
        Bar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="box_and_whisker")]
        BoxAndWhisker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pie")]
        Pie,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scatter")]
        Scatter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="superchart")]
        Superchart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
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