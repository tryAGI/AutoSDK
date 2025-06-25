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
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Cumulative,
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
                UsageAggregationInterval.Hour => "hour",
                UsageAggregationInterval.Day => "day",
                UsageAggregationInterval.Week => "week",
                UsageAggregationInterval.Month => "month",
                UsageAggregationInterval.Cumulative => "cumulative",
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
                "hour" => UsageAggregationInterval.Hour,
                "day" => UsageAggregationInterval.Day,
                "week" => UsageAggregationInterval.Week,
                "month" => UsageAggregationInterval.Month,
                "cumulative" => UsageAggregationInterval.Cumulative,
                _ => null,
            };
        }
    }
}