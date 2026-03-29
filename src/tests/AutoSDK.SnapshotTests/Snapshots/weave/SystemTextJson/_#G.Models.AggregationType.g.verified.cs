//HintName: G.Models.AggregationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregation functions supported by feedback and call stats metrics.
    /// </summary>
    public enum AggregationType
    {
        /// <summary>
        /// 
        /// </summary>
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        CountFalse,
        /// <summary>
        /// 
        /// </summary>
        CountTrue,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AggregationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AggregationType value)
        {
            return value switch
            {
                AggregationType.Avg => "avg",
                AggregationType.Count => "count",
                AggregationType.CountFalse => "count_false",
                AggregationType.CountTrue => "count_true",
                AggregationType.Max => "max",
                AggregationType.Min => "min",
                AggregationType.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AggregationType? ToEnum(string value)
        {
            return value switch
            {
                "avg" => AggregationType.Avg,
                "count" => AggregationType.Count,
                "count_false" => AggregationType.CountFalse,
                "count_true" => AggregationType.CountTrue,
                "max" => AggregationType.Max,
                "min" => AggregationType.Min,
                "sum" => AggregationType.Sum,
                _ => null,
            };
        }
    }
}