//HintName: G.Models.GetFocusReportTimeframe.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetFocusReportTimeframe
    {
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="day")]
        Day,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hour")]
        Hour,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minute")]
        Minute,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="month")]
        Month,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="week")]
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFocusReportTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportTimeframe value)
        {
            return value switch
            {
                GetFocusReportTimeframe.Day => "day",
                GetFocusReportTimeframe.Hour => "hour",
                GetFocusReportTimeframe.Minute => "minute",
                GetFocusReportTimeframe.Month => "month",
                GetFocusReportTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetFocusReportTimeframe.Day,
                "hour" => GetFocusReportTimeframe.Hour,
                "minute" => GetFocusReportTimeframe.Minute,
                "month" => GetFocusReportTimeframe.Month,
                "week" => GetFocusReportTimeframe.Week,
                _ => null,
            };
        }
    }
}