//HintName: G.Models.AnalyticsOperationOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the aggregation operation you want to perform.
    /// </summary>
    public enum AnalyticsOperationOperation
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
        History,
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
    public static class AnalyticsOperationOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsOperationOperation value)
        {
            return value switch
            {
                AnalyticsOperationOperation.Avg => "avg",
                AnalyticsOperationOperation.Count => "count",
                AnalyticsOperationOperation.History => "history",
                AnalyticsOperationOperation.Max => "max",
                AnalyticsOperationOperation.Min => "min",
                AnalyticsOperationOperation.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsOperationOperation? ToEnum(string value)
        {
            return value switch
            {
                "avg" => AnalyticsOperationOperation.Avg,
                "count" => AnalyticsOperationOperation.Count,
                "history" => AnalyticsOperationOperation.History,
                "max" => AnalyticsOperationOperation.Max,
                "min" => AnalyticsOperationOperation.Min,
                "sum" => AnalyticsOperationOperation.Sum,
                _ => null,
            };
        }
    }
}