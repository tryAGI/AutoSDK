//HintName: G.Models.RunStatsGroupBySeriesResponseAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStatsGroupBySeriesResponseAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_type")]
        RunType,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag")]
        Tag,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata")]
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