//HintName: G.Models.CohortAggregatedResultGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CohortAggregatedResultGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortAggregatedResultGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortAggregatedResultGroupBy value)
        {
            return value switch
            {
                CohortAggregatedResultGroupBy.Day => "day",
                CohortAggregatedResultGroupBy.Hour => "hour",
                CohortAggregatedResultGroupBy.Month => "month",
                CohortAggregatedResultGroupBy.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortAggregatedResultGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "day" => CohortAggregatedResultGroupBy.Day,
                "hour" => CohortAggregatedResultGroupBy.Hour,
                "month" => CohortAggregatedResultGroupBy.Month,
                "week" => CohortAggregatedResultGroupBy.Week,
                _ => null,
            };
        }
    }
}