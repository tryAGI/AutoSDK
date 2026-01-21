//HintName: G.Models.RunStatsGroupBySeriesResponseSetBy2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStatsGroupBySeriesResponseSetBy2
    {
        /// <summary>
        /// 
        /// </summary>
        Section,
        /// <summary>
        /// 
        /// </summary>
        Series,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatsGroupBySeriesResponseSetBy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatsGroupBySeriesResponseSetBy2 value)
        {
            return value switch
            {
                RunStatsGroupBySeriesResponseSetBy2.Section => "section",
                RunStatsGroupBySeriesResponseSetBy2.Series => "series",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatsGroupBySeriesResponseSetBy2? ToEnum(string value)
        {
            return value switch
            {
                "section" => RunStatsGroupBySeriesResponseSetBy2.Section,
                "series" => RunStatsGroupBySeriesResponseSetBy2.Series,
                _ => null,
            };
        }
    }
}