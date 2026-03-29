//HintName: G.Models.WebSearchRequestTimeRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filters results to content published within the specified time range back from the current date. For example, `week` or `w` returns results from the past 7 days.
    /// </summary>
    public enum WebSearchRequestTimeRange
    {
        /// <summary>
        /// 
        /// </summary>
        D,
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        M,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        W,
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Y,
        /// <summary>
        /// 
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestTimeRange value)
        {
            return value switch
            {
                WebSearchRequestTimeRange.D => "d",
                WebSearchRequestTimeRange.Day => "day",
                WebSearchRequestTimeRange.M => "m",
                WebSearchRequestTimeRange.Month => "month",
                WebSearchRequestTimeRange.W => "w",
                WebSearchRequestTimeRange.Week => "week",
                WebSearchRequestTimeRange.Y => "y",
                WebSearchRequestTimeRange.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "d" => WebSearchRequestTimeRange.D,
                "day" => WebSearchRequestTimeRange.Day,
                "m" => WebSearchRequestTimeRange.M,
                "month" => WebSearchRequestTimeRange.Month,
                "w" => WebSearchRequestTimeRange.W,
                "week" => WebSearchRequestTimeRange.Week,
                "y" => WebSearchRequestTimeRange.Y,
                "year" => WebSearchRequestTimeRange.Year,
                _ => null,
            };
        }
    }
}