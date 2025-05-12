//HintName: G.Models.RunStatsGroupBySeriesResponseSetBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStatsGroupBySeriesResponseSetBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="section")]
        Section,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="series")]
        Series,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatsGroupBySeriesResponseSetByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatsGroupBySeriesResponseSetBy value)
        {
            return value switch
            {
                RunStatsGroupBySeriesResponseSetBy.Section => "section",
                RunStatsGroupBySeriesResponseSetBy.Series => "series",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatsGroupBySeriesResponseSetBy? ToEnum(string value)
        {
            return value switch
            {
                "section" => RunStatsGroupBySeriesResponseSetBy.Section,
                "series" => RunStatsGroupBySeriesResponseSetBy.Series,
                _ => null,
            };
        }
    }
}