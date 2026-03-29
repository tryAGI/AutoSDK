//HintName: G.Models.GetUsageTimeframe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum GetUsageTimeframe
    {
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Day,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Hour,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Minute,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Month,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsageTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageTimeframe value)
        {
            return value switch
            {
                GetUsageTimeframe.Day => "day",
                GetUsageTimeframe.Hour => "hour",
                GetUsageTimeframe.Minute => "minute",
                GetUsageTimeframe.Month => "month",
                GetUsageTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetUsageTimeframe.Day,
                "hour" => GetUsageTimeframe.Hour,
                "minute" => GetUsageTimeframe.Minute,
                "month" => GetUsageTimeframe.Month,
                "week" => GetUsageTimeframe.Week,
                _ => null,
            };
        }
    }
}