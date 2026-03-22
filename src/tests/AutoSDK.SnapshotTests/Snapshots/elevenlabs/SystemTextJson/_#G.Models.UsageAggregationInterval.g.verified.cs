//HintName: G.Models.UsageAggregationInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The time interval over which to aggregate the usage data.
    /// </summary>
    public enum UsageAggregationInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Cumulative,
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
    public static class UsageAggregationIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageAggregationInterval value)
        {
            return value switch
            {
                UsageAggregationInterval.Cumulative => "cumulative",
                UsageAggregationInterval.Day => "day",
                UsageAggregationInterval.Hour => "hour",
                UsageAggregationInterval.Month => "month",
                UsageAggregationInterval.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageAggregationInterval? ToEnum(string value)
        {
            return value switch
            {
                "cumulative" => UsageAggregationInterval.Cumulative,
                "day" => UsageAggregationInterval.Day,
                "hour" => UsageAggregationInterval.Hour,
                "month" => UsageAggregationInterval.Month,
                "week" => UsageAggregationInterval.Week,
                _ => null,
            };
        }
    }
}