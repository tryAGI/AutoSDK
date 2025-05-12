//HintName: G.Models.RunStatsGroupBySeriesResponseAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStatsGroupBySeriesResponseAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        RunType,
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStatsGroupBySeriesResponseAttributeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStatsGroupBySeriesResponseAttribute value)
        {
            return value switch
            {
                RunStatsGroupBySeriesResponseAttribute.Name => "name",
                RunStatsGroupBySeriesResponseAttribute.RunType => "run_type",
                RunStatsGroupBySeriesResponseAttribute.Tag => "tag",
                RunStatsGroupBySeriesResponseAttribute.Metadata => "metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStatsGroupBySeriesResponseAttribute? ToEnum(string value)
        {
            return value switch
            {
                "name" => RunStatsGroupBySeriesResponseAttribute.Name,
                "run_type" => RunStatsGroupBySeriesResponseAttribute.RunType,
                "tag" => RunStatsGroupBySeriesResponseAttribute.Tag,
                "metadata" => RunStatsGroupBySeriesResponseAttribute.Metadata,
                _ => null,
            };
        }
    }
}