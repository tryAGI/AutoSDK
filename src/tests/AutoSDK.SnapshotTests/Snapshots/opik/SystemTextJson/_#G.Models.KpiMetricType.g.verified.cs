//HintName: G.Models.KpiMetricType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KpiMetricType
    {
        /// <summary>
        /// 
        /// </summary>
        AvgCost,
        /// <summary>
        /// 
        /// </summary>
        AvgDuration,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        Errors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KpiMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KpiMetricType value)
        {
            return value switch
            {
                KpiMetricType.AvgCost => "avg_cost",
                KpiMetricType.AvgDuration => "avg_duration",
                KpiMetricType.Count => "count",
                KpiMetricType.Errors => "errors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KpiMetricType? ToEnum(string value)
        {
            return value switch
            {
                "avg_cost" => KpiMetricType.AvgCost,
                "avg_duration" => KpiMetricType.AvgDuration,
                "count" => KpiMetricType.Count,
                "errors" => KpiMetricType.Errors,
                _ => null,
            };
        }
    }
}