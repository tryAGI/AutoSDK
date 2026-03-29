//HintName: G.Models.GetAnalyticsTimeframe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum GetAnalyticsTimeframe
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
    public static class GetAnalyticsTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsTimeframe value)
        {
            return value switch
            {
                GetAnalyticsTimeframe.Day => "day",
                GetAnalyticsTimeframe.Hour => "hour",
                GetAnalyticsTimeframe.Minute => "minute",
                GetAnalyticsTimeframe.Month => "month",
                GetAnalyticsTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetAnalyticsTimeframe.Day,
                "hour" => GetAnalyticsTimeframe.Hour,
                "minute" => GetAnalyticsTimeframe.Minute,
                "month" => GetAnalyticsTimeframe.Month,
                "week" => GetAnalyticsTimeframe.Week,
                _ => null,
            };
        }
    }
}